using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using ScottPlot;

namespace Kiosk.App;

class Results {
    public void Run() {
        Console.WriteLine("Results");
        double[] xs = new double[] {1, 2, 3, 4, 5};
        double[] ys = new double[] {1, 4, 9, 16, 25};

        var plt = new ScottPlot.Plot(400, 300);
        plt.AddScatter(xs, ys);
        plt.SaveFig("console.png");
    }
}