﻿/*  MyNetSensors 
    Copyright (C) 2015 Derwish <derwish.pro@gmail.com>
    License: http://www.gnu.org/licenses/gpl-3.0.txt  
*/

namespace MyNetSensors.Nodes
{
  public class UiRgbwSlidersNode : UiNode
    {
      public string Value { get; set; }

      public UiRgbwSlidersNode() : base(0, 1)
      {
            this.Title = "UI RGBW Sliders";
            this.Type = "UI/RGBW Sliders";
            this.DefaultName = "RGBW";
            Value = "00000000";
           Outputs[0].Value = Value.ToString();
        }

        public override void Loop()
        {
        }

        public override void OnInputChange(Input input)
        {
        }

        public void SetValue(string value)
        {
            Value = value;
            LogInfo($"UI RGBW Sliders [{Name}]: [{Value}]");
            Outputs[0].Value = Value;
        }
    }
}