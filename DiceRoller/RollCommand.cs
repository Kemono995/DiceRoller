using DiceRoller.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DiceRoller
{
    public class RollCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        MainWindowViewModel viewModel;

        public RollCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, new EventArgs());
        }


        public bool CanExecute(object parameter)
        {
            int diceNumber;
            int diceSize;
            
            int rerollLimit;

            if(!Int32.TryParse(viewModel.DiceNumber, out diceNumber) || !Int32.TryParse(viewModel.DiceSize, out diceSize)  || !Int32.TryParse(viewModel.RerollLimit, out rerollLimit))
            {
                return false;
            }
            if(diceNumber<0 || diceSize<0  || rerollLimit<0)
            {
                return false;
            }

            return true;
        }

        public void Execute(object parameter)
        {






           
            int rerollThreshold =Int32.Parse( viewModel.RerollLimit) ;

            
            int diceNumber = Int32.Parse(viewModel.DiceNumber);
            int diceSize = Int32.Parse(viewModel.DiceSize);

            
            ResultStrategy resultStrategy;

            if (viewModel.RollOption == RollOptions.Total)
            {
                resultStrategy = new TotalResult(diceSize, diceNumber, viewModel.AdvantageOption, rerollThreshold);
            }
            else
            {
                resultStrategy = new AverageResult(diceSize, diceNumber, viewModel.AdvantageOption, rerollThreshold);
            }
            viewModel.Result = resultStrategy.Result().ToString();




        }
    }
}
