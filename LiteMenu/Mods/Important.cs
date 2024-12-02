using System;
using System.Collections.Generic;
using System.Text;

namespace FlysPanelLite.Mods
{
    internal class Important
    {
        public static void ReportAll()
        {
            GorillaPlayerScoreboardLine[] ScoreBoardLine = UnityEngine.Object.FindObjectsOfType<GorillaPlayerScoreboardLine>();
            foreach (GorillaPlayerScoreboardLine ReportLine in ScoreBoardLine)
            {
                if (ReportLine.linePlayer != null)
                {
                    ReportLine.PressButton(true, GorillaPlayerLineButton.ButtonType.Toxicity);
                }
            }
        }

        public static void MuteAll()
        {
            GorillaPlayerScoreboardLine[] ScoreBoardLine = UnityEngine.Object.FindObjectsOfType<GorillaPlayerScoreboardLine>();
            foreach (GorillaPlayerScoreboardLine MuteLine in ScoreBoardLine)
            {
                if (MuteLine.linePlayer != null)
                {
                    MuteLine.PressButton(true, GorillaPlayerLineButton.ButtonType.Mute);
                    MuteLine.muteButton.isOn = true;
                    MuteLine.muteButton.UpdateColor();
                }
            }
        }
    }
}
