using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork1806
{
    public class MailMessageEventArgs : EventArgs
    {
        private string _from;
        private string _to;
        private string _text;

        public string From
        {
            get { return _from; }
        }

        public string To
        {
            get { return _to; }
        }

        public string Text
        {
            get { return _text; }
        }

        public MailMessageEventArgs(string from, string to, string text)
        {
            this._from = from;
            this._to = to;
            this._text = text;
        }
    }

    public class Messanger
    {
        public delegate void MailDelegate(Object sender, MailMessageEventArgs args);

        public event MailDelegate NewMailSent;

        protected virtual void OnNewMailSent(MailMessageEventArgs args)
        {
            NewMailSent(sender:this, args);
        }

        public void SendNewMail(string from, string to, string text)
        {
            MailMessageEventArgs args = new MailMessageEventArgs(from, to, text);
            OnNewMailSent(args);
        }
    }

    public class Fax
    {
        private readonly Messanger _messanger;

        public Fax(Messanger messanger)
        {
            this._messanger = messanger;
            this._messanger.NewMailSent += FaxMessage;
        }

        public void FaxMessage(Object sender, MailMessageEventArgs args)
        {
            Console.WriteLine($"From {args.From}\n To: {args.To}\n Text: {args.Text}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var messanger = new Messanger();
            var fax = new Fax(messanger);
            messanger.SendNewMail(from:"fromAddress", to:"toAddress", text:"some text");
        }
    }
}
