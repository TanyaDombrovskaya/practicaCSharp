using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Cinoteatr
{
    public class CinemaViewModel : INotifyPropertyChanged
    {
        private string _selectedFilm;
        private string _selectedTime;
        private int _ticketCount;
        private decimal _totalPrice;
        private string _selectedSeats;

        public ObservableCollection<string> Films { get; set; }
        public ObservableCollection<string> Times { get; set; }

        private ObservableCollection<List<string>> _seatsData;

        public ObservableCollection<List<string>> SeatsData
        {
            get => _seatsData;
            set
            {
                _seatsData = value;
                OnPropertyChanged(nameof(SeatsData));
            }
        }

        public string SelectedFilm
        {
            get => _selectedFilm;
            set
            {
                _selectedFilm = value;
                OnPropertyChanged(nameof(SelectedFilm));
            }
        }

        public string SelectedTime
        {
            get => _selectedTime;
            set
            {
                _selectedTime = value;
                OnPropertyChanged(nameof(SelectedTime));
            }
        }

        public int TicketCount
        {
            get => _ticketCount;
            set
            {
                _ticketCount = value;
                OnPropertyChanged(nameof(TicketCount));
                ChangePrice(_ticketCount);
            }
        }

        public decimal TotalPrice
        {
            get => _totalPrice;
            set
            {
                _totalPrice = value;
                OnPropertyChanged(nameof(TotalPrice));
            }
        }

        public string SelectedSeats
        {
            get => _selectedSeats;
            set
            {
                _selectedSeats = value;
                OnPropertyChanged(nameof(SelectedSeats));
            }
        }

        public ICommand SelectFilmCommand { get; }
        public ICommand SelectTimeCommand { get; }
        public ICommand ReserveCommand { get; }
        public ICommand CancelCommand { get; }
        public ICommand ChangeCommand { get; }

        public CinemaViewModel()
        {
            SeatsData = GenerateGridData();

            Films = new ObservableCollection<string> { "SuperMan", "Ambasador", "FilmFilm" };
            Times = new ObservableCollection<string> { "15:00", "18:00", "21:00" };

            SelectFilmCommand = new RelayCommand(film =>
            {
                if (film is string selectedFilm)
                {
                    SelectedFilm = selectedFilm;
                }
            });

            SelectTimeCommand = new RelayCommand(time =>
            {
                if (time is string selectedTime)
                {
                    SelectedTime = selectedTime;
                }
            });

            ReserveCommand = new RelayCommand(_ => ExecuteReserve());
            CancelCommand = new RelayCommand(_ => ExecuteCancel());
            ChangeCommand = new RelayCommand(_ => ExecuteChange());
        }

        private ObservableCollection<List<string>> GenerateGridData()
        {
            var data = new ObservableCollection<List<string>>();
            int counter = 1;
            for (int i = 0; i < 10; i++)
            {
                var row = new List<string>();
                for (int j = 0; j < 5; j++)
                {
                    row.Add(counter.ToString());
                    counter++;
                }
                data.Add(row);
            }
            return data;
        }

        public void ChangePrice(int count)
        {
            TotalPrice = 15 * count; 
        }

        private void ExecuteReserve()
        {
            if (!string.IsNullOrEmpty(SelectedSeats) &&
                !string.IsNullOrEmpty(SelectedTime) &&
                !string.IsNullOrEmpty(SelectedFilm) &&
                TicketCount > 0)
            {
                MessageBox.Show($"Вы забронировали:" +
                                $"\nМесто: {SelectedSeats}" +
                                $"\nКоличество билетов: {TicketCount}" +
                                $"\nВремя: {SelectedTime}" +
                                $"\nФильм: {SelectedFilm}");
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void ExecuteCancel()
        {
            MessageBox.Show("Бронь мест отменена.");
        }

        private void ExecuteChange()
        {
            Change change = new Change();
            change.Show();
        }

        public void ProcessSelectedCells(IEnumerable<DataGridCellInfo> selectedCells)
        {
            var mestaList = new List<string>();
            foreach (var cell in selectedCells)
            {
                if (cell.Item is DataRowView rowView)
                {
                    var columnIndex = cell.Column.DisplayIndex;
                    var cellValue = rowView.Row.ItemArray[columnIndex]?.ToString()?.Trim();
                    if (!string.IsNullOrEmpty(cellValue))
                    {
                        mestaList.Add(cellValue);
                    }
                }
            }

            SelectedSeats = string.Join(", ", mestaList);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
