﻿using System;
using Core.Main;
using Core.Main.DataObjects;

namespace Monitor.Pages {
  public class DashboardTopModel : _Internal.BasePageModelSecureAJAX {
    public ProfitTrailerData PTData = null;
    public DateTimeOffset DateTimeNow = Constants.confMinDate;
    public void OnGet() {
      // Initialize Config
      base.Init();

      BindData();
    }
    public double TotalBagCost = 0;
    public double TotalBagValue = 0;
    public double TotalBagGain = 0;
    private void BindData() {
      PTData = this.PtDataObject;

      // Convert local offset time to UTC
      TimeSpan offsetTimeSpan = TimeSpan.Parse(PTMagicConfiguration.GeneralSettings.Application.TimezoneOffset.Replace("+", ""));
      DateTimeNow = DateTimeOffset.UtcNow.ToOffset(offsetTimeSpan);
    }
  }
}
