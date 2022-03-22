using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Controller
    {
        private Model _model;

        private enum Action
        {
            SUM;
            SUB;
            DEV;
            MULTY;
        }

        public Controller(Model model)
        {
            _model = model;
        }
        /* проверка model */

    }

    internal void CalculateResult(Action action a, int b)
    {
        switch (action)
        {
            case Action.SUM:
                _model.SUM(a,b);
                break;
            case Action.SUM:
                _model.SUB(a, b);
                break;
            case Action.SUM:
                _model.DEV(a, b);
                break;
            case Action.SUM:
                _model.MULTY(a, b);
                break;

        }
    }
    {
        _model.Sum(a, b);
    }
}
