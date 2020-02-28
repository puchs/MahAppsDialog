using System;
using System.Windows;

using MahApps.Metro.Controls.Dialogs;

namespace MahAppsDialog {
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application {
    protected override void OnStartup(StartupEventArgs e) {
      if (e is null)
        throw new ArgumentNullException(nameof(e));

      base.OnStartup(e);

      var dialog = new CustomDialog() { Title = "This dialog allows arbitrary content." };
      dialog.ShowDialogExternally();
    }
  }
}
