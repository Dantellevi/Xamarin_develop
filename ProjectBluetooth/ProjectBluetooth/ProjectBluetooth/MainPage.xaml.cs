using Plugin.BLE.Abstractions.Contracts;
using Plugin.BLE.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectBluetooth
{
	public partial class MainPage : ContentPage
	{

        IAdapter adapter;
        IBluetoothLE bluetoothBLE;
        ObservableCollection<IDevice> list;
        IDevice device;

        public MainPage()
		{
			InitializeComponent();
            list = new ObservableCollection<IDevice>();
            DeviceList.ItemsSource = list;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (bluetoothBLE.State == BluetoothState.Off)
            {
                await DisplayAlert("Внимание!!!", "Bluetoth откл. включите блитус", "OK");
            }
            else
            {
                list.Clear();

                adapter.ScanTimeout = 10000;
                adapter.ScanMode = ScanMode.Balanced;


                adapter.DeviceDiscovered += (obj, a) =>
                {
                    if (!list.Contains(a.Device))
                        list.Add(a.Device);
                };

                await adapter.StartScanningForDevicesAsync();

            }
        }

        private async void DeviceList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            device = DeviceList.SelectedItem as IDevice;

            var result = await DisplayAlert("Внимание", "Вы хотите подключиться к этому устройству?", "Подключиться", "Отмена");

            if (!result)
                return;

            //Stop Scanner
            await adapter.StopScanningForDevicesAsync();

            try
            {
                await adapter.ConnectToDeviceAsync(device);

                await DisplayAlert("Подключено.", "Статус:" + device.State, "OK");

            }
            catch (DeviceConnectionException ex)
            {
                await DisplayAlert("Ошибка: ", ex.Message, "OK");
            }
        }
    }
}
