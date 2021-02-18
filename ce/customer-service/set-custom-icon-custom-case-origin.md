---
title: Set custom icon for custom Case Origin field (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to set custom icon for custom Case Origin field in Dynamics 365 Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 06/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Set the custom icon in views for Case Origin field

In [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] you can set a custom icon to display in views where the Case Origin field is visible.  
  
## Case Origin field icons  
 The Case Origin field has the following options and a corresponding icon is displayed in views within the application:  
  
|Label|Value|Icon|  
|-----------|-----------|----------|  
|**Phone**|1|![Case origin icon for phone](../customerengagement/on-premises/customize/media/case-origin-phone-icon.png "Case origin icon for phone")|  
|**Email**|2|![Case origin button for email](../customerengagement/on-premises/customize/media/case-origin-email-icon.png "Case origin button for email")|  
|**Web**|3|![Case origin icon for web](../customerengagement/on-premises/customize/media/case-origin-web-icon.png "Case origin icon for web")|  
|**Facebook**|2483|![Facebook Case origin icon](../customerengagement/on-premises/customize/media/case-origin-facebook-icon.png "Facebook Case origin icon")|  
|**Twitter**|3986|![Case origin icon for Twitter](../customerengagement/on-premises/customize/media/case-origin-twitter-icon.png "Case origin icon for Twitter")|  
  
 You can edit the case origin field to add additional options. The options used by this field are defined within the **Case Origin** global option set. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit global option sets](../customerengagement/on-premises/customize/create-edit-global-option-sets.md)  
  
 When you add a custom option, by default this icon will be displayed: ![Case origin icon for a custom origin](../customerengagement/on-premises/customize/media/case-origin-custom-icon.png "Case origin icon for a custom origin"). You can specify a different icon by creating an image web resource using the steps below:  
  
## Set a custom icon for a custom case origin  
  
1. If the customization prefix for the solution publisher associated with the unmanaged solution you are working in is not ‘new’ you must change the solution publisher customization prefix to ‘new’ temporarily while you create this image web resource. After you create this web resource, set it back to whatever value you want to use. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Solution publisher](../customerengagement/on-premises/customize/change-solution-publisher-prefix.md).
  
2. Create a 16x16 pixel icon to represent your custom case origin. A PNG file with a transparent background is recommended.  
  
3. Identify the value for the custom option for the **Case Origin** global option set. By default, the first custom option value will be set to 100,000,000 and will increment for each additional option.  
  
4. Create a PNG format image web resource using the following naming convention: ‘new_Incident_origincode_icon<em>#</em>.png’ where *#* represents the value for the custom option.  
  
   [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit web resources](../customerengagement/on-premises/customize/create-edit-web-resources.md)  
  
   For example, for a custom option with a value of 100,000,000 create a web resource with the name new_Incident_origincode_icon100000000.png.  
  
   > [!IMPORTANT]
   >  Do not include commas in the name of the web resource.   
   > The solution publisher customization prefix is prepended to the name of the web resource and this value must be ‘new’.  
  
   Use the **Upload File** button in the web resource form to upload the icon file you created.  
  
5. Save and publish your web resource.  
  
6. To verify, create a case record using the custom case origin and verify that a view that displays the case origin icon shows your custom icon.  
  
    There may be a several minutes delay after you publish your custom web resource. You may need to press F5 to refresh the page in your browser.  
  
### See also  
 [Create and edit global option sets](../customerengagement/on-premises/customize/create-edit-global-option-sets.md)   
 [Create and edit web resources](../customerengagement/on-premises/customize/create-edit-web-resources.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]