using _03Prokhorov.Model.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace _03Prokhorov.ViewModel
{
    internal class ViewModel
    {
        public static bool CalculateAge(DateTime? birthDate)
        {
            if (birthDate != null)
            {
                DateTime today = DateTime.Today;
                int age = today.Year - birthDate.Value.Year;
                if (birthDate > today.AddYears(-age)) age--;
                try
                {
                    if (age > 135)
                    {
                        throw new AgeTooLowException("AgeTooLowException");
                    }
                    else if (age < 0)
                    {
                        throw new AgeTooHighException("AgeTooHighException");
                    }
                    else
                    {
                        if (birthDate.Value.Month == today.Month && birthDate.Value.Day == today.Day)
                            MessageBox.Show("Happy B-day!");
                        return true;
                    }
                }
                catch (AgeTooLowException atl)
                {
                    //MessageBox.Show("AgeTooLowException");
                }
                catch (AgeTooHighException ath)
                {
                    //MessageBox.Show("AgeTooHighException");
                }
            }
            return false;
        }
    }
}
