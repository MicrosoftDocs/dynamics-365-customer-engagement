The schedule board supports directly displaying the service account field of a parent schedulable entity when viewing the booking template on an aggregated view such as daily, weekly, or monthly. When enabled, this app setting respects security settings such as field security on the account-related fields.

The *msdyn_EnableInterdayAccountName* global setting controls this feature. You can enable it with a toggle on the [Scheduling Parameters form](../../field-service/scheduling-parameters-settings.md) or by using browser console commands.  

## Enable or disable account names on interday booking template with browser console commands

1. Open the schedule board in the browser. 
1. Launch the developer tools of your browser and open the console.
1. Run the following script to enable the setting. To disable it, change the boolean value to `false`.

   ```
   Xrm.Utility.getGlobalContext().saveSettingValue("msdyn_EnableInterdayAccountName",true)

   Xrm.Utility.getGlobalContext().getCurrentAppSettings();
   ```

1. Refresh your browser after running the script.  
