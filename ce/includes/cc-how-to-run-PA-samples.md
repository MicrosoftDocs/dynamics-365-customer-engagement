To obtain a local copy of all samples and build them, follow these steps:
1. Download or clone the  [Samples](https://github.com/microsoft/PowerApps-Samples) repo so that you have a local copy.
2. (Optional) Edit the cds/App.config file to define a connection string specifying the instance or organization you want to connect to.
3. Open the sample solution in Visual Studio and press **F5** to run the sample. After you specify a connection string in cds/App.config, any sample you run will use that connection information.

If you don't specify a connection string in cds/App.config file, a dialog opens each time you run the sample, and you need to enter information about which instance or org you want to connect to and which credentials you want to use. This dialog caches previous connections so that you can choose a previously used connection.
