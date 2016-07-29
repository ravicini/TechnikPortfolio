using System.Collections.Generic;
using System.IO;
using TechnikPortfolio.TechRadar.Formtting;

namespace TechnikPortfolio.TechRadar
{
    public class RadarGenerator
    {
        public void GenerateRadar(string portfolioName, IReadOnlyList<Issue> issues)
        {
            // todo: fill these quadrants properly
            var data = PopulateRadarData.ForRadarWithName("bbv Tech Radar")
                .InQuadrant(Quadrant.TopLeft)
                    .Add(() => issues)
                .InQuadrant(Quadrant.TopRight)
                    .Add(() => issues)
                .InQuadrant(Quadrant.BottomLeft)
                    .Add(() => issues)
                .InQuadrant(Quadrant.BottomRight)
                    .Add(() => issues)
                .GetPopulatedRadar();

            var formatter = new RadarFormatter();

            var jsFileContent = formatter.FormatDataToJsString(data);
            File.WriteAllText("radar.js", jsFileContent);

            var htmlTemplate = formatter.FormatHtmlFor("radar.js");
            File.WriteAllText("radar.html", htmlTemplate);
        }
    }
}