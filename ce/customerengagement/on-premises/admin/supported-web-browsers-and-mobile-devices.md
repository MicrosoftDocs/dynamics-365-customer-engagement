---
title: "Supported web browsers and mobile devices | MicrosoftDocs"
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
ms.assetid: 078f5277-db51-4a62-a20c-976db74f17a4
caps.latest.revision: 29
author: Mattp123
ms.author: matp
manager: brycho
search.audienceType: 
  - admin

---
# Supported web browsers and mobile devices

Users can access the model-driven apps with the most recent versions of these popular browsers:  
  
- Microsoft Edge (recommended: [Chromium-based Edge](https://support.microsoft.com/help/4501095/download-the-new-microsoft-edge-based-on-chromium))
- Chrome
- Firefox  
- Safari
- Internet Explorer (not recommended)

> [!NOTE]
> For optimal performance and experience, we recommend you use the latest version of a modern browser. Microsoft Internet Explorer 11 support is deprecated. We recommend that you use Microsoft Edge. More information: [Deprecation announcement](/power-platform/important-changes-coming#internet-explorer-11-support-for-dynamics-365-and-microsoft-power-platform-is-deprecated)
  
For more detailed information about supported browsers, see [Web application requirements](web-application-requirements.md).  
  
For a mobile device, such as an iPad or smartphone, the following apps are available:  
  
- [Dynamics 365 for phones and Dynamics 365 for tablets](../../../mobile-app/install-dynamics-365-for-phones-and-tablets.md)
  
For more detailed information about supported phones and tablets, see [Dynamics 365 mobile and tablet device support](../../../mobile-app/support-phones-tablets.md).  
  
  
> [!NOTE]
> - Users who try to view Customer Engagement (on-premises) on an unsupported browser may be redirected to a mobile experience. 
>   - For Customer Engagement (on-premises) version 9.0 and later, users are redirected to the Unified Interface experience. For more information see [Unified Interface Overview](about-unified-interface.md). 
>   - For versions earlier than Customer Engagement (on-premises) version 9.0, users are redirected to [!INCLUDE [pn-crm-for-phones-express](../includes/pn-crm-for-phones-express.md)]. This is a basic service that has limited functionality, and isn’t intended to serve as a substitute for the full feature set of Customer Engagement (on-premises) version 9.0 apps. We recommend that users choose a supported browser or a Customer Engagement (on-premises) version 9.0 app specific to the device. 
> -  If you have added content to forms or dashboards in an iFrame, you might have implemented security restrictions around certain actions in that content, such as external links. Keep in mind that in [!INCLUDE[tn_Firefox](../includes/tn-firefox.md)], this security restriction code will likely be unsupported.  
  
<a name="BKMK_browserIssues"></a>   
## Known issues when you run Customer Engagement (on-premises) version 9.0 apps with certain web browsers  
 This section describes the known issues when you run Customer Engagement (on-premises) version 9.0 apps in a web browser.  
  
### Limited copy and paste support in Firefox and Chrome  
 Copy and paste functionality by using the clipboard is not yet fully supported on the [!INCLUDE[tn_Firefox](../includes/tn-firefox.md)] and [!INCLUDE[tn_chrome](../includes/tn-chrome.md)] web browsers; the **Copy a Link** button at the top of the page may not function as expected.  
  
### You receive an error opening an Excel worksheet when you use Safari  
 If you export an [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] worksheet as a Dynamic Worksheet while using [!INCLUDE[tn_Safari](../includes/tn-safari.md)], you may receive an error when trying to open the file. To remedy this, right-click the file, click **Get Info**, and, under **Open With**, select [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)].  
### See Also  
 [Key preparation and configuration tasks](../admin/key-preparation-and-configuration-tasks.md)
 [Supported web browsers and mobile devices - earlier versions](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn531055(v=crm.8))


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]