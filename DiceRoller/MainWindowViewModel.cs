using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DiceRoller
{
    public enum RollOptions { Total, Average }
    public enum AdvantageOptions { Regular, Advantage, Dissadvantage }

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged(this, e);
        }
        private string diceSize;
        private string diceNumber;
        private string rerollLimit;
        private string result;

        public RollOptions RollOption { get; set; }
        public AdvantageOptions AdvantageOption { get; set; }

        public ICommand ExecuteCommand { get; set; }

        public string DiceSize
        {
            get
            {
                return diceSize;

            }
            set
            {
                int newVal = 0;
                Int32.TryParse(value, out newVal);
                
                
                diceSize = newVal.ToString();
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("diceSize"));
            }
        }
        public string DiceNumber
        {
            get
            {
                return diceNumber;

            }
            set
            {
                int newVal = 0;
                Int32.TryParse(value, out newVal);


                diceNumber = newVal.ToString();
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("diceNumber"));
            }
        }
        public string RerollLimit
        {
            get
            {
                return rerollLimit;

            }
            set
            {
                int newVal = 0;
                Int32.TryParse(value, out newVal);


                rerollLimit = newVal.ToString();
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("rerollLimit"));
            }
        }
        public string Result
        {
            get
            {
                return result;

            }
            set
            {
                double newVal = 0;
                Double.TryParse(value, out newVal);


                result = newVal.ToString();
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("result"));
            }
        }

        public MainWindowViewModel()
        {
            diceSize = "20";
            diceNumber = "0";
            result = "0";
            rerollLimit = "0";
            ExecuteCommand = new RollCommand(this);
            RollOption = RollOptions.Total;
            AdvantageOption = AdvantageOptions.Regular;
        }
    }
}
