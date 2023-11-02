1. Download or clone the [Dynamics365-Apps-Samples](https://github.com/microsoft/Dynamics365-Apps-Samples) repo so that you have a local copy.
2. (Optional) Edit the dataverse/App.config file to define a connection string specifying the Common Data Service instance you want to connect to.
3. Open the sample solution in Visual Studio and press **F5** to run the sample. After you specify a connection string in dataverse/App.config, any sample you run will use that connection information.

If you do not specify a connection string in dataverse/App.config file, a dialog will open each time you run the sample and you will need to enter information about which Dataverse instance you want to connect to and which credentials you want to use. This dialog will cache previous connections so that you can choose a previously used connection.

Those samples in this repo that require a connection to a Common Data Service instance to run will include a linked reference to the dataverse/App.config file.

