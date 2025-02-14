using Core.Librarys.Browser;
using Core.Models.WebPage;
using Core.Servicers.Interfaces;
using Newtonsoft.Json;
using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Core.Servicers.Instances
{
    public class WebServer : WebSocketBehavior, IWebServer
    {
        private WebSocketServer _webSocket;
        private bool _isStart = false;

        public void Start()
        {
            if (_isStart) return;
            try
            {
                _webSocket = new WebSocketServer(8908, false);
                _webSocket.AddWebSocketService<WebServer>("/ClockGoblinWebSentry");
                _webSocket.Start();
                _isStart = true;
            }
            catch (Exception ex)
            {
                Librarys.Logger.Error("无法启动浏览器服务，" + ex);
            }
        }

        public void Stop()
        {
            if (!_isStart) return;
            _webSocket?.Stop();
            _isStart = false;
        }

        public void SendMsg(string msg_)
        {
            try
            {
                if (!_isStart) return;

                _webSocket.WebSocketServices.Broadcast(msg_);
            }
            catch (Exception ec)
            {
                Librarys.Logger.Error(ec.ToString());
            }
        }


        protected override void OnMessage(MessageEventArgs e)
        {
            try
            {
                var log = JsonConvert.DeserializeObject<NotifyWeb>(e.Data);
                WebSocketEvent.Invoke(log);
            }
            catch
            {

            }
        }
    }
}
