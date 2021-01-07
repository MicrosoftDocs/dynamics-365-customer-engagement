---
title: "Key preparation and configuration tasks | MicrosoftDocs"
ms.custom: 
ms.date: 01/07/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 77628b79-4436-4c75-bb71-26f72a00894f
caps.latest.revision: 31
author: Mattp123
ms.author: matp
manager: brycho
search.audienceType: 
  - admin

---
# Key preparation and configuration tasks

This topic, which is intended for administrators and business users of Dynamics 365 Customer Engagement (on-premises), describes common configuration settings and tasks that can help you keep your organization optimized so that you can focus on what’s important. It’s designed to improve your overall experience with Customer Engagement (on-premises), even before your business begins to use it.  

> [!NOTE]
> Microsoft Internet Explorer 11 support is deprecated. We recommend that you use Microsoft Edge. More information: [Deprecation announcement](https://docs.microsoft.com/power-platform/important-changes-coming#internet-explorer-11-support-for-dynamics-365-and-microsoft-power-platform-is-deprecated)
  
<a name="bkmk_commonconfig"></a>   

## Common configuration settings for Internet Explorer  
 Customer Engagement (on-premises) is a web-based application and uses web browsers, such as [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)], as the user interface to view, add, or edit information that you’ve stored in the Customer Engagement (on-premises) database. Make the following common [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] configuration settings to optimize your Customer Engagement (on-premises) experience.  
  
 **Increase disk space for temporary Internet files**  
  
 To make sure that Internet files for Customer Engagement (on-premises) are not being deleted, increase the disk space for temporary Internet files.  
  
1. Open [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)], and on the **Tools** menu, click or tap **Internet Options**.  
  
2. On the **General** tab, in the **Browsing history** section, click or tap **Settings**.  
  
3. Set the **Disk space to use** field to **350**.  
  
4. Click or tap **OK**, and then click or tap **OK** again.  
  
**Retain browsing history**  
  
To optimize your Customer Engagement (on-premises) experience, we recommend that you do not select the option to delete the browsing history when you exit from your browser. If you select this option, it deletes everything marked in your **Browsing history** settings, such as temporary Internet files, cookies, and history (by default, the check boxes for these options are selected). Deleting your temporary Internet files causes [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] to cache the files again, and deleting cookies signs you out of Customer Engagement (on-premises).  
  
1. Open [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)], and on the **Tools** menu, click or tap **Internet Options**.  
  
2. Click or tap the **General** tab, and in the **Browsing history** section, make sure that the **Delete browsing history on exit** check box is cleared.  
  
   Customer Engagement (on-premises) occasionally uses pop-up windows. Your browser may be blocking these windows because of the pop-up blocker settings. You must configure the pop-up blocker settings to allow pop-up windows for the Customer Engagement (on-premises) websites.  
  
   Customer Engagement (on-premises) occasionally uses pop-up windows. Your browser may be blocking these windows because of the pop-up blocker settings. You must configure the pop-up blocker settings to allow pop-up windows for the Customer Engagement (on-premises) websites.  
  
   **If you experience slower performance in Internet Explorer**  
  
If your Customer Engagement (on-premises) performance is slower in Internet Explorer than in other browsers, set **JavaScript Timer Frequency** to **Maximum Performance**.  
  
1. Go to **Control Panel** > **System and Security** > **Power Options**.  
  
2. For your active power plan, click **Change plan settings** > **Change advanced power settings**.  
  
3. Expand **Internet Explorer** > **JavaScript Timer Frequency**, for **On battery** and **Plugged in**, choose **Maximum Performance**.  
  
   ![Internet Explorer power options](../admin/media/crm-itpro-iepoweroptions.png "Internet Explorer power options")  
  
**Increase data storage limits for websites**  
  
Every time you visit a website, [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] stores the website data as cache, and uses it when you open the website again. This increases your browsing speed. [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] can store up to a maximum of 10 MB cache data. If your users visit a particular website often, it will store a lot of content on their system, and it may reach the maximum limit of data storage. To avoid this, you may want to increase the data storage limit for your browser.  
  
 Here are two ways you can increase the data storage limit for [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)].  
  
### Increase data storage limit by using group policy  
  
1. On your keyboard, press the Windows key + R.  
  
2. In the **Run** dialog box, type `gpedit.msc`, and click **OK**.  
  
   **Local Group Policy Editor** opens.  
  
3. Navigate to **Computer Configuration** > **Administrative Templates** > **Windows Components** > **Internet Explorer** > **Internet Control Panel** > **General Page** > **Browsing History**.  
  
4. In the right pane, double-click the setting **Set default storage limits for websites**.  
  
5. In the **Set default storage limits for websites** dialog box, click **Enabled**, and then in the **Options** section, in the **Set default storage limit for websites** field, add the required limit.  
  
6. Click **Apply**, and then click **OK**.  
  
7. Close Local Group Policy Editor, and restart the computer.  
  
### Increase data storage limit by using Registry Editor  
  
1. On your keyboard, press the Windows key + R.  
  
2. In the **Run** dialog box, type `regedit`, and click **OK**.  
  
   **Registry Editor** opens.  
  
3. Navigate to the key: HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft.  
  
4. Create a subkey **Internet Explorer** inside **Microsoft**.  
  
   1.  Right-click **Microsoft**, and then click **New** > **Key**.  
  
   2.  Type **Internet Explorer** as the name of the subkey.  
  
5. Similarly, create a subkey **BrowserStorage** in the newly created subkey **Internet Explorer**.  
  
6. Click the **BrowserStorage** subkey, and in the right pane, right-click, and then click **New** > **DWORD Value**.  
  
7. Type `DefaultDomainCacheLimitInMB` as the name.  
  
8. Double-click the DWORD item you just created.  
  
9. In the **Edit DWORD Value** dialog box, select **Decimal** as **Base**, and then enter the required storage limit in MB, and click **OK**.  
  
10. Close Registry Editor, and restart the computer.  
  
<a name="bkmk_networkconnections"></a>   

## Network connections settings  
 Network connections are established based on the order that the device is listed in the **Adapters and Bindings** tab of the Network Connections window. For example, if you have enabled a Local Area Network (LAN) and a wireless connection, the order of how a device is connected to the Internet is based on its order in the **Adapter and Bindings** list. If the LAN connection is higher in the list, most network connections will be established by using the LAN adapter instead of the wireless adapter. To make sure that your network connections are optimized, organize the connections according to your network administrator's recommendation.  
  
 **To change the network connection order**  
  
1.  Right-click **Start** and then click or tap **Run**.  
  
2.  Type: `control netconnections` and then click or tap **OK**.  
  
3.  Click or tap **Organize** > **Layout** > and verify **Menu bar** is checked.  
  
4.  Click or tap **Advanced** > **Advanced Settings**.  
  
5.  Click or tap the **Adapters and Bindings** tab, and then, under **Connections**, click or tap the connection that you want to move in the list, click or tap the up or down arrow button, and then click or tap **OK**.  
  
<a name="bkmk_antivirusormalware"></a>   

## Antivirus or malware application settings  
 Depending on your antivirus or malware application settings, virus scanning can block certain files, making them inaccessible to other applications and causing an adverse effect on Customer Engagement (on-premises) performance.  
  
 Each environment requires a thoughtful decision on what to include and exclude, and there is always a possibility that excluding files from scans could lead to unwanted consequences. Use the following list alongside your well-planned internal IT management policies:  
  
- Check for any interference from desktop security software. Some antivirus programs include a feature known as ScriptScan that can affect the performance of Customer Engagement (on-premises). Most programs have functionality to disable scanning on certain websites. Make sure that the Customer Engagement (on-premises) URL is added to this list. For McAfee specifically, see the following KB articles for this setting:  
  
  -   [McAfee Knowledge Base Article: KB65382](https://kc.mcafee.com/corporate/index?page=content&id=KB65382)  
  
  -   [Microsoft Support Knowledge Base Article: KB924341](https://go.microsoft.com/fwlink/p/?LinkId=232344)  
  
- If you use other antivirus software, make sure that the URL of the Customer Engagement (on-premises) website is included in the trusted zone for the virus scanning, and disable on-access scanning for the Customer Engagement (on-premises) website.  For more information, see the specific antivirus application documentation.  
  
<a name="bkmk_availableresources"></a>   

## Available resources   
 We want you and your organization to take full advantage of the extensive content and materials available that can help your business be more successful while you are using Customer Engagement (on-premises). For a list of available resources, including training materials and information about how to support your online organization, see the [Help and additional resources](help-additional-resources.md).  
  
<a name="bkmk_techsupp"></a>   

## Technical support  
 If you cannot find the answers you need in the resources discussed earlier, you can submit a technical support request to [!INCLUDE[pn_ms_Customer_Support_Services](../includes/pn-ms-customer-support-services.md)]. Technical support incidents provide reactive support that focuses on a specific problem, error message, or functionality that is not working as intended. For assistance information, see [Support](https://go.microsoft.com/fwlink/p/?LinkID=394391).  
  
### Maximize your technical support experience  
 When you request help for technical issues or questions, it is important that you have as much information available as possible. Here are common questions that you may be asked when you request technical support:  
  
- What part of the application are you having issues with?  
  
   For example, installation issues with [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)].  
  
- What is the exact error or problem that you are experiencing?  
  
   Provide detailed information, including the exact error message that you are seeing. Include a screen capture if you can.  
  
- What were you doing in Customer Engagement (on-premises) when the error occurred?  
  
   Provide the exact steps that you are performing to reproduce the error. This lets the Support team better analyze why you may be experiencing it.  
  
- What are the details of the environment you are experiencing the issue on?  
  
   Provide the version of the operating system, browser, and if applicable, the version of [!INCLUDE[pn_MS_Office](../includes/pn-ms-office.md)] on the computers where the issue is occurring.  
  
- Does the issue affect all users or a certain type of Customer Engagement (on-premises) security role or only certain users?  
  
  When possible, provide log files (if you know how to find them). This applies to applications such as [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] or [!INCLUDE[pn_CRM_E-Mail_Router](../includes/pn-crm-e-mail-router.md)]. The following table lists the location of the log or trace files for these applications.  
  
|   Logs or Traces                |   Log File Location                            |
|-----------------------------|-------------|
|    Customer Engagement (on-premises) for Outlook logs     |  %Userprofile%\Local Settings\Application Data\Microsoft\MSCRM\Logs  |
| Customer Engagement (on-premises) for Outlook Trace files | %Userprofile%\Local Settings\Application Data\Microsoft\MSCRM\Traces |
|   Customer Engagement (on-premises) E-mail Router logs    |          %Userprofile%\AppData\Roaming\Microsoft\MSCRM\Logs          |
  
### See also  
 [Set up an organization](../admin/set-up-a-dynamics-365-organization.md)
