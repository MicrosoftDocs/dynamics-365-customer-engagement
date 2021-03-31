---
title: "Use the Chrome Process hosting method for your controls in Unified Service Desk  | MicrosoftDocs"
description: "Learn about the Chrome Process hosting method for your controls in Unified Service Desk."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 02/15/2021
ms.topic: "article"
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
monikerRange: '>= dynamics-usd-4.1'
---

# Use Chrome Process to host web applications

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

The Chrome Process browser control hosts your controls in isolated Chrome Process instances and displays them in tabs in the Unified Service Desk client application. Chrome Process is based on *CefSharp*, an open source framework that uses the Chromium core that powers many modern browsers.  More information: [CefSharp](https://cefsharp.github.io/)

> [!IMPORTANT]
> - Unified Service Desk version 4.1.1.1429 supports Chromium version 84.
> - Unified Service Desk version 4.1.1.1397 supports Chromium version 71.

The advantages of using the Chrome process hosting method are as follows:

- It's available on different Windows operating system versions.
- It's highly reliable.
- You can easily make configurations to host applications in Unified Service Desk.
- You can switch easily from one browser to another for your entire organization.
- The Chrome Process pooling feature that reuses the Chrome processes and mimics inline navigation provides enhanced performance and memory optimization.

You can select **Chrome Process** as the hosting method for the **KM Control**, **Unified Interface Page**, **Unified Interface KM Control**, **CRM Page** , **Channel Integration Framework**, and **Standard Web Application** types of hosted controls.

## Chrome Process settings

You can set Chrome Process on the hosted controls (existing hosted controls and new hosted controls) to host applications. This way, you can choose the hosted controls that use Chrome Process based on your requirements. More information: [Create a hosted control with hosting type as Chrome](chrome-process.md#create-a-hosted-control-with-hosting-type-as-chrome)

If you want to set Chrome Process to host applications for an entire organization, use the **GlobalBrowserMode** Global UII option and specify the value as **Chrome**. More information: [Enable Chrome for Unified Service Desk on client desktop](chrome-process.md#enable-chrome-for-unified-service-desk-on-client-desktops)

If you want to set Chrome Process only for some agents in your organization, in the **UnifiedServiceDesk.exe.config** file, add the **GlobalBrowserMode** key with the value as **Chrome**. More information: [Enable Chrome for an entire organization](chrome-process.md#enable-chrome-for-an-entire-organization)

### Order of precedence

- Setting the **GlobalBrowserMode** Global UII option value as **Chrome** takes precedence over the individual hosted control settings. <br><br>For example, some hosted controls have a hosting type of **IE Process**, **Chrome Process**, or **Internal WPF**. At the organization level, you set the **GlobalBrowserMode** Global UII option value as **Chrome**. In this scenario, the Global UII option takes precedence and the configuration will use Chrome Process to host the applications. 

- Setting the **GlobalBrowser** mode key to **Chrome** in the **UnifiedServiceDesk.exe.config** file for a particular client desktop takes precedence over the individual hosted control settings.<br><br>For example, some hosted controls have a hosting type of **IE Process** or **Internal WPF**. In the client desktops for a few agents, you've set the **GlobalBrowser** mode key to **Chrome** in the **UnifiedServiceDesk.exe.config** file. The value set in the **UnifiedServiceDesk.exe.config** file will take precedence, and the configuration will use Chrome Process to host the applications.

## Enable Chrome Process

Enable Chrome Process in one of the following ways:

- Create an individual hosted control with the hosting type of Chrome Process.
- Enable Chrome for individual client desktops.
- Enable Chrome for an entire organization.

<a name="create-a-hosted-control-with-hosting-type-as-chrome"></a>
### Create a hosted control with the hosting type of Chrome Process

When you're creating a new hosted control, you can select **Chrome Process** as the **Hosting Type**.

1. Sign in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Hosted Controls**. The page displays available hosted controls.

4. Select **New**.

5. On the **New Hosted Control** page, specify the details. From the **Hosting Type** list, select **Chrome Process**.

6. Select **Save** to create the hosted control.

  > [!div class="mx-imageBorder"]
  > ![Select hosting type as Chrome Process](media/hosted-control-chrome-process.GIF "Create a hosted control with hosting type as Chrome Process")

### Enable Chrome for Unified Service Desk on client desktops

1. Go to the directory where you've installed Unified Service Desk and double-click to open the **UnifiedServiceDesk.exe.config** file.
Example path: C:\Program Files\Microsoft Dynamics CRM USD\USD
  
  > [!NOTE] 
  > To edit the UnifiedServiceDesk.exe.config file, you must have administrator access permissions.

2. In the `<appSettings>` section, add the following new key.<br>
`<add key="GlobalBrowserMode" value="Chrome"/>`

3. Save the file.

  > [!div class="mx-imageBorder"]
  > ![Add a GlobalBrowserMode key with the value of Chrome](media/chrome-process-app-config-file-setting.GIF "Add a GlobalBrowserMode key with the value of Chrome")

### Enable Chrome for an entire organization

Add a new Global UII option named **GlobalBrowserMode** for your organization, and specify the value as **Chrome**.

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. For the **Global Option** field, select **Others**.

5. For the **Name** field, enter **GlobalBrowserMode**.

6. For the **Value** field, enter **Chrome**.

7. Select **Save**.

  > [!div class="mx-imageBorder"]
  > ![For the Global Option field, enter GlobalBrowserMode with a value of Chrome](media/chrome-process-uii-option.GIF "For the Global Option field, enter GlobalBrowserMode with a value of Chrome")

## Recover a Chrome Process instance

[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] can help agents to recover the terminated (crashed) webpages hosted in Chrome Process in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].

More information: [Recover a Chrome Process instance](admin/recover-chrome-process-instance.md)

## RunScript action is asynchronous in Chrome Process

Chrome Process supports only asynchronous operations, and the RunScript action will be asynchronous. If your custom code execution is dependent on the return value provided by the RunScript action that injects JavaScript into the main frame of the application, your custom code execution might fail.

For example, your custom code has a RunScript action that injects JavaScript into the main frame of the application followed by an operation or another RunScript action. The RunScript action is invoked and returns a value after the JavaScript injection. If the subsequent operation, or another RunScript action, is executed based on the return value provided by the executed RunScript action, subsequent operations of your custom code will fail.

### Scenario example

In this example, whenever you open a case, you verify whether the case has been open for 10 or more days, then display a message in a dialog box. When you perform an action in the dialog box, a phone call page is opened for further operations.

To perform the abovementioned scenario, you must have an action call that executes a RunScript action and returns a value for the next operation. The data on the action call calculates the number of days the case has been open.

Now, you must create an action call with an action as ExecuteOnDataAvailable, and the data field must have the return value of the first action call. That is, the return value will have the form `[[$Return.ActionCallName]]`. This ensures that after the first action is executed and the return is available, this action call will be executed.

Next, you must create a subsequent action call to show the number of days a case has been in the open state. The data field will use the return value from the first action call&mdash;that is, `[[$Return.ActionCallName]]`.

You must create another subsequent action call to open the phone call page and perform the next operation. After seeing the message, you select **OK** in the dialog box, and this causes the phone call page to open.

Let's see what configurations you need to create for this scenario.

### Step 1: Create a hosted control

1. Go to **Settings** > **Unified Service Desk** > **Hosted Controls**.

2. Select **New**.

3. Add the following details, and save the hosted control.

   | Field | Value |
   |--------|---------|
   | Name | Incident |
   | Display Name | `[[incident.title]]` |
   | Unified Service Desk Component Type | Unified Interface Page |
   | Hosting Type | Chrome Process |
   | Display Group | MainPanel |

### Step 2: Create two action calls

1. Go to  **Settings** > **Unified Service Desk** > **Action Calls**.

2. Select **New**.

3. Add the following details, and save the action call.

   | Field | Value |
   |--------|---------|
   | Name | FindNoOfDaysCaseBeingOpened |
   | Order | 1 |
   | Hosted Control | Incident |
   | Action | RunScript |
   | Data | function findAge(dateString)</br>{</br>if("[[incident.statuscode]]".indexOf("1") > -1){</br>var date1 =new Date(dateString);</br>var date2 =new Date();</br>var timeDiff = Math.abs(date2.getTime() - date1.getTime());</br>var diffDays = Math.ceil(timeDiff / (1000 * 3600 * 24));</br>return diffDays.toString();</br>}</br>return 0;</br>}</br>findAge("[[incident.createdon]]"); |

4. Repeat steps 2 and 3 to create another action call, using the following details.

   | Field | Value |
   |--------|---------|
   | Name | DaysValue|
   | Order | 2 |
   | Hosted Control | CRM Global Manager |
   | Action | ExecuteOnDataAvailable |
   | Data | `[[$Return.FindNoOfDaysCaseBeingOpened]]` |

#### Step 3: Create two action calls, and add them under the DaysValue action call

1. Go to **Settings** > **Unified Service Desk** > **Action Calls**.

2. Select **New**.

3. Add the following details, and save the action call.

   | Field | Value |
   |--------|---------|
   | Name | DisplayMessageForCaseOpen |
   | Hosted Control | CRM Global Manager |
   | Action | DisplayMessage |
   | Data | 	text=No of days case is in open state: [[$Return.FindNoOfDaysCaseBeingOpened]]<br>caption=Case is open |

4. Repeat steps 2 and 3 to create another action call, using the following details.

   | Field | Value |
   |--------|---------|
   | Name | OpenPhoneCallPage |
   | Hosted Control | PhoneCall |
   | Action | New_CRM_Page |
   | Data | 		LogicalName=phonecall<br>description=Long pending case more than 9 days <br> subject=Long pending case <br> |
   | Condition | "[[$Return.FindNoOfDaysCaseBeingOpened]]">9 |

5. From the list of action calls, select the **DaysValue** action call.

6. In the navigation bar, next to the **DaysValue** action call, select the **>** icon, and then select **Sub Action Call**.

7. Select the **ADD EXISTING ACTION CALL** option. In the search field, enter the action **DisplayMessageForCaseOpen**, and then select **Search**.

8. To add the action call, select the action call name that appears.

9. Perform steps 7 and 8 to add the **OpenPhoneCallPage** action call.

10. Save the changes.

#### Step 4: Add the action calls to the PageReady event

1. Go to  **Settings** > **Unified Service Desk** > **Events**.

2. Select the **PageReady** event for the **Incident** hosted control from the list of events.

3. On the event page, in the **Active Actions** area, select **+** to add action calls.

4. In the search box that appears, enter **FindNoOfDaysCaseBeingOpened**, select **Search**, and then select the action call. The action call appears in the **Active Actions** area.

5. Repeat step 4 to add the **DaysValue** action.

6. Save the changes.

## Sign out from sessions when using Chrome Process

To sign out from sessions when using Chrome Process, you must configure the sign-out URL by using the **Navigate** action on the hosted control. For example, the sign-out URL is `url=/main.aspx?signout=1`.

## Support for webcam and microphone access with Chrome Process

Agents in your organization probably require webcam and microphone access, according to your business workflow. By default, certain websites might not have access to webcams or microphones. To enable webcam and microphone support for Chrome Process, use the **ChromeEnableMediaStream** UII option. Set the UII option to **True**. If you don't provide any value or set this to **False**, the option will be disabled.
<!--markdownlint-disable MD036-->
**To add the ChromeEnableMediaStream UII option**

 1. Sign in to the Dynamics 365 instance.

 2. Go to **Settings** > **Unified Service Desk** > **Options**.

 3. On the **Active UII Options** page, select **New**. 
 
 4. For the **Global Option** field, select **Others**.

 5. For the **Name** field, enter **ChromeEnableMediaStream**.

 6. For the **Value** field, enter **True**.

 7. Select **Save**.

## Debug Chrome Process

You can debug Chrome Process in two ways:

- Remotely

- Locally

### Debug Chrome Process remotely

When you want to access and debug all the Chrome Process instances running in a desktop remotely, you need to have remote debugging access along with the port number.

Use the **ChromeRemoteDebuggingPort** UII option and add the port number as the value. After setting this value, from the web browser, go to the `<IP address>:<\port number>` of the remote desktop. You can see all the Chrome Process instances running in that desktop, and then you can proceed with debugging.

### Debug Chrome Process locally

When you want to access and debug all the Chrome Process instances running in a desktop locally, you need to have access along with the port number to connect to.

Use the **ChromeRemoteDebuggingPort** UII option and add the port number as the value. After setting this value, from the web browser, go to the `localhost:<\port number>` of the local desktop. You can see all the Chrome Process instances running in that desktop, and then you can proceed with debugging.

Also, within the Unified Service Desk client application, you can debug a Chrome Process instance by using the keyboard shortcut **F12** to open **Developer Tools**. More information: [Manage options in Unified Service Desk](admin/manage-options-unified-service-desk.md)

**To add the ChromeRemoteDebuggingPort UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. For the **Global Option** field, select **Others**.

5. For the **Name** field, enter **ChromeRemoteDebuggingPort**. For the **Value** field, enter the port number (for example, **1030**).

6. Select **Save**.

## Enable the close confirmation dialog box with Chrome Process

With Chrome Process, if you accidentally close any application, the close confirmation dialog box for the application doesn't appear and the application closes without user confirmation. To avoid closing the application accidentally, use the **OnBeforeCloseHandler** UII option. 

If ***onbeforeunload*** event handlers are set for the page loaded in the hosted control, ***onbeforeunload*** event handlers are called if this UII option is set to **True**. If the UII option is set to **False**, the event handlers aren't called.

**To add the OnBeforeCloseHandler UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. For the **Global Option** field, select **Others**.

5. For the **Name** field, enter **OnBeforeCloseHandler**. For the **Value** field, enter **True**.

6. Select **Save**.

## Enable the confirmation dialog box with Chrome Process

If you perform an action on an app tab within a Unified Service Desk session and close the session, the **ChromeProcessConfirmationDialog** UII option will display a dialog box so you can confirm the saving and closing of a session. 

The confirmation dialog box is displayed if this UII option has been added or the value is set as **True**. If this option hasn't been added or the value is set as **False**, the confirmation dialog box isn't displayed.

**To add the ChromeProcessConfirmationDialog UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. For the **Global Option** field, select **Others**.

5. For the **Name** field, enter **ChromeProcessConfirmationDialog**. For the **Value** field, enter **True**.

6. Select **Save**.

## Set zoom in, zoom out, and zoom reset keyboard shortcuts

By default, the keyboard shortcuts for zoom in, zoom out, and zoom reset are as follows.

| Function | Keyboard shortcut | Example |
|----------|------------|-----------|
| Zoom in |`Ctrl` + `Oemplus`| **Ctrl**+**Plus sign (+)** |
| Zoom out |`Ctrl` + `OemMinus`| **Ctrl**+**Hyphen (-)**|
| Zoom reset |`Ctrl` + `0`| **Ctrl**+**0**|

To add keyboard shortcuts, you must add the UII options and provide the character as the value. To learn about the allowed set of character values, go to [Keys](https://docs.microsoft.com/dotnet/api/system.windows.forms.keys?view=netframework-4.7.2#fields).

### List of zoom control UII options

| UII option | Description | Example character |
|------------|-------------|-------------------|
| ZoomInControlKey | Add a new character to support the zoom-in control when using Chrome Process. | `A` |
| ZoomOutControlKey |Add a new character to support the zoom-out control when using Chrome Process. | `D1` |
| ZoomResetControlKey | Add a new character to support the zoom-reset control when using Chrome Process. | `NumPad4` |

> [!Important]
> Before providing a value for the new character:
>
> - Ensure that the character you choose for the UII option doesn't conflict with your existing keyboard shortcuts.
>
> - Note that if you leave the value blank, the default keyboard shortcuts will be disabled.

**To add the zoom control UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. For the **Global Option** field, select **Others**.

5. For the **Name** field, enter the name of the UII option. For the **Value** field, enter value you want.<br> Go to the preceding [list of zoom control UII options](#list-of-zoom-control-uii-options).<br>Go to the list of [value keys](https://docs.microsoft.com/dotnet/api/system.windows.forms.keys?view=netframework-4.7.2#fields).

6. Select **Save**.

## Set the default zoom value for Chrome Process

You can set the default zoom value for Chrome Process as a fraction according to your users' visual preference. You can set it for:

- Individual users
- Your entire organization

**To set the default zoom value for individual users**

You can set the default value for individual users by using the UnifiedServiceDesk.exe.config file.

1. Go to directory where you've installed Unified Service Desk, and double-click to open **UnifiedServiceDesk.exe.config**.
Example path: C:\Program Files\Microsoft Dynamics CRM USD\USD

   > [!NOTE]
   > To edit the UnifiedServiceDesk.exe.config file, you must have administrator access permissions.

2. In the `<appSettings>` section, add the new key.<br>
`<add key="DefaultZoomLevel" value="<fraction value>"/>`<br> For example: `<add key="DefaultZoomLevel" value="0.3"/>`

3. Save the file.

**To set the default zoom value for your entire organization**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. For the **Global Option** field, select **Others**.

5. For the **Name** field, enter **DefaultZoomLevel**. For the **Value** field, enter the fractional value you want (for example, **0.3**, **0.5**, or **1.1**).

6. Select **Save**.

## Allow webpage navigation with unauthorized, expired, and invalid certificates in Chrome Process

If you're navigating to a webpage that has invalid Secure Sockets Layer (SSL) certificates, or unauthorized or expired certificates, Chrome Process blocks the webpage navigation.

To ignore certificate errors and allow navigation to all websites, you must add the **AllowWebpageNavigationCertificateError** UII option and set the value as **True**.

If you don't want to allow navigation to all such websites but instead choose specific ones, provide a comma-separated list of the websites for which you want to ignore certificate errors (for example, **wrong.host.testssl.com,self-signed.testssl.com**).

If you leave the value blank or set it as **False**, Chrome Process will block webpage navigation for all websites that have certificate errors.

**To add the AllowWebpageNavigationCertificateError UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. For the **Global Option** field, select **Others**.

5. For the **Name** field, enter **AllowWebpageNavigationCertificateError**. For the **Value** field, enter **True** or a comma-separated list of the websites you want to allow navigation to (for example, **wrong.host.testssl.com,self-signed.testssl.com**).

6. Select **Save**.

## Accessibility support with Chrome Process

With Chrome Process, you can enable accessibility support for webpages by using the **ChromeAccessibilityRenderer** option. This option enables screen reader applications to read the webpage. The Chromium Embedded Framework mandates the **force-renderer-accessibility** setting to be enabled when a screen reader is detected. The **force-renderer-accessibility** setting is applied if the UII option hasn't been added or the value is set to **True**. After adding the UII option, if you set it to **False** or leave the value empty, the UII option is disabled.

**To add the ChromeAccessibilityRenderer UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. For the **Global Option** field, select **Others**.

5. For the **Name** field, enter **ChromeAccessibilityRenderer**. For the **Value** field, enter **True**.

6. Select **Save**.

## Set focus on webpage when using Chrome Process

With Chrome Process, if you want to set the focus on a webpage automatically, you must create an action call with the action as **RunScript** and **Data** with a JavaScript function: `window.top.USDChromeSetFocus()`. After you create the action call, add it to the **PageReady** event for **Unified Interface Page**, and add it to the **BrowserDocumentComplete** event for the **CRM Page** hosted control.

## Handling the URI protocol in Chrome Process

When using Chrome Process, you might want to block the protocol navigation inside the Unified Service Desk client application, or you might want to open the application in a separate window outside of the Unified Service Desk client application. Use the window navigation rules to block or open the application outside of the Unified Service Desk client application.

Add the URL in **Window Navigation Rules** and set the **Action** to **None** to block the navigation, and set **Show Outside** to show the application outside of Unified Service Desk client application.

For example, say you've integrated a softphone with Unified Service Desk and are using the Chrome Process hosting type to host web applications. When an agent selects the phone number in the contact or account page, you want to initiate the call by using the softphone instead of Skype. You create the window navigation rule and set the **Action** to **None** to block the Skype protocol. You can create specific action calls as sub-action calls of this window navigation rule to initiate the call using the softphone.

**To create a window navigation rule**

1. Sign in to the Dynamics 365 instance.

2. Expand **Dynamics 365**.

3. Select **Unified Service Desk Administrator**.

4. Under **Basic Settings**, select **Window Navigation Rules**.

5. On the **Active Window Navigation Rules** page, select **New**.

6. Specify the following values on the **New Window Navigation Rules** page.

   | Tab |  Field | Value |
   |-------------------|------------------------------------------------|--------------------------------------------------|
   | General | Name | Telephone Protocol <br><br> or <br><br> Skype Protocol |
   | General | Url | tel: <br><br> or <br><br> skype: |
   | Result | Route Type | Popup |
   | Result | Action | None or Show Outside |

7. Select **Save**.

Now when an agent selects the number in the contact or account page, based on the window navigation rule, Chrome Process blocks or opens the application outside of the Unified Service Desk client application.

## Generate Chrome Process crash reports

To investigate Chrome Process crashes in Unified Service Desk, you must generate the crash reports. Add the **ChromeEnableLogging** UII option and set the value as **True**.  The files will be written to the following location: C:\Users\\<agent1\>\AppData\Roaming\Microsoft\USD\CEF\cef_debug.log

**To add the ChromeEnableLogging UII option**

1. Sign in to the Dynamics 365 instance.

2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]

3. Select **Options**.  

4. On the **Active UII Options** page, select **New**.

5. For the **Global Option** field, select **Others**.

6. For the **Name** field, enter **ChromeEnableLogging**.

7. For the **Value** field, enter **True**.

8. Select **Save**.

## Add parameters using Chrome Process

The Chrome Process provides many options that can be used on the webpages within Unified Service Desk. The **ChromeProcessParameters** option helps to add the parameters. The format to add the parameters is:<br> ` --force-ui-direction:rtl;--force-text-direction:rtl;--log-level:3 `<br>Note that the parameters are separated by semicolons. More information: [Chromium command-line switches](https://go.microsoft.com/fwlink/p/?linkid=2149189)

**To add the ChromeProcessParameters UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Options**.

4. On the **Active UII Options** page, select **New**.

5. For the **Global Option** field, select **Others**.

6. For the **Name** field, enter **ChromeProcessParameters**.

7. For the **Value** field, enter **True**.

8. Select **Save**.

## Use the window.IsUSD property to invoke a Unified Service Desk event

With Chrome Process, if you use the `window.IsUSD` property in your JavaScript code, you must use it on predefined events like **pageReady** and **BrowserDocumentComplete** to determine whether the JavaScript code is running under Unified Service Desk.

When you use the property on the Unified Service Desk predefined events, the property returns true. Otherwise, it returns false.

## Download attachments in Chrome Process

When you use Chrome Process to host web applications in Unified Service Desk and select a file attachment, by design Chrome Process prompts you to save the file to a local folder. After saving the file, you can open it to view it.

As an admin, you can use the **ChromeProcessDownloadPath** UII option to set the default folder to save attachments in while using Chrome Process pages, for example C:\Users\\<user_name\>\Desktop\USD patch docs.

Chrome Process prompts you to save the file to a local folder:

- If the field value is empty.
- If the path provided isn't a valid folder.
- If you don't have write permissions to the selected path.

**To add the ChromeProcessDownloadPath UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Options**.

4. On the **Active UII Options** page, select **New**.

5. For the **Global Option** field, select **Others**.

6. For the **Name** field, enter **ChromeProcessDownloadPath**.

7. For the **Value** field, enter **True**.

8. Select **Save**.

## Edit a PDF in Chrome Process

Chrome Process supports the ability to edit a PDF file inline if the PDF has editable fields.

## Check spelling on a webpage in Chrome Process

Chrome Process supports the ability to check spelling on webpages within Unified Service Desk. To enable the spell checker, you must add the **SetSpellCheckLanguage** UII option.

**To add the SetSpellCheckLanguage UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Options**.

4. On the **Active UII Options** page, select **New**.

5. For the **Global Option** field, select **Others**.

6. For the **Name** field, enter **SetSpellCheckLanguage**.

7. For the **Value** field, enter the locale code. More information: [Languages Codes](https://go.microsoft.com/fwlink/p/?linkid=2153933)

    > [!NOTE]
    > Only the locales available in the path C:\Program Files\Microsoft Dynamics CRM USD\USD\locales are supported.

8. Select **Save**.

## Limitations

To learn about the limitations of Chrome Process, go to [Chrome Process limitations](release-notes.md).


### See also

[Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md)  
[Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)  
[Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)  
[Recover a Chrome Process instance](admin/recover-chrome-process-instance.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]