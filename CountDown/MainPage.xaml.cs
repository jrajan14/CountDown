using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization.DateTimeFormatting;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CountDown
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int selectedYear;
        int selectedMonth;
        int selectedDay;
        int selectedHour;
        int selectedMinute;
        int selectedSecond;
        int selectedMillisecond;
        DateTime endDateTime;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void BtnSelectDateTime_Click(object sender, RoutedEventArgs e)
        {
            selectedYear = PickDate.Date.Year;
            selectedMonth = PickDate.Date.Month;
            selectedDay = PickDate.Date.Day;
            selectedHour = PickTime.Time.Hours;
            selectedMinute = PickTime.Time.Minutes;
            selectedSecond = 0;
            selectedMillisecond = 0;

            endDateTime = new DateTime(selectedYear, selectedMonth, selectedDay, selectedHour, selectedMinute, selectedSecond, selectedMillisecond);

            TxtEndDate.Text = endDateTime.ToString() + ":" + endDateTime.Millisecond.ToString();
          
        }

        private async void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                int nowYear = DateTime.Now.Year;
                int nowMonth = DateTime.Now.Month;
                int nowDay = DateTime.Now.Day;
                int nowHour = DateTime.Now.Hour;
                int nowMinute = DateTime.Now.Minute;
                int nowSecond = DateTime.Now.Second;
                int nowMillisecond = DateTime.Now.Millisecond;

                DateTime nowDateTime = new DateTime(nowYear, nowMonth, nowDay, nowHour, nowMinute, nowSecond, nowMillisecond);

                TimeSpan diffDate = nowDateTime - endDateTime; //TOTAL TIMESPAN DIFFERENCE

                int diffYear = nowYear - selectedYear; // For Future usage
                int diffMonth = nowMonth - selectedMonth; // For Future usage

                //DISPLAY DAYS
                int diffDay = diffDate.Days;
                TxtDays.Text = diffDay.ToString();

                //DISPLAY HOURS
                int diffdaysToHours = diffDay * 24; //Days to hours
                int remainingHours = diffDate.Hours + diffdaysToHours;
                TxtHours.Text = remainingHours.ToString();

                //DISPLAY MINUTES
                long diffHoursToMins = remainingHours * 60;
                long remainingMinutes = diffDate.Minutes + diffHoursToMins;
                TxtMinutes.Text = remainingMinutes.ToString();

                //DISPLAY SECONDS
                long diffMinutesToSeconds = remainingMinutes * 60;
                long remainingSeconds = diffDate.Seconds + diffMinutesToSeconds;
                TxtSeconds.Text = remainingSeconds.ToString();

                //DISPLAY MILLI-SECONDS
                long diffSecondsToMilliSeconds = remainingSeconds * 1000;
                long remainingMilliSeconds = (diffDate.Milliseconds + diffSecondsToMilliSeconds);
                await Task.Delay(1);
                TxtMilliSeconds.Text = "T" + (remainingMilliSeconds).ToString();
            }

        }
    }
}
