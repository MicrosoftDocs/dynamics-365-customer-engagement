To enable the legacy schedule board, you need to set the solution setting `msdyn_EnableOldScheduleBoard` to true. You can do so using the XRMUtility, or through a solution by adding the settings solution component. To add the setting to a solution, follow the steps [in this article](/power-apps/maker/data-platform/create-edit-configure-settings#adding-an-existing-setting-environment-value).

An example of the [XRM Utility](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-utility/getglobalcontext) command to change this setting is given below.

```javascript
//Check the value of the setting
Xrm.Utility.getGlobalContext().getCurrentAppSettings()["msdyn_EnableOldScheduleBoard"] 

//Enable the legacy schedule board 
 Xrm.Utility.getGlobalContext().saveSettingValue("msdyn_EnableOldScheduleBoard", true, {overrideScope: 1}).then(() => {a = "success"}, (error) => {a = error})
 ```

Once the legacy schedule board has been enabled in your environment, individual users will be able to toggle between the legacy and new experiences directly on the schedule board.
