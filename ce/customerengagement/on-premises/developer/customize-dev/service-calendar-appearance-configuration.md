---
title: "Service calendar appearance configuration | MicrosoftDocs"
description: "Learn about the configuration of the service calendar appearance configuration."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - service calendar, appearance
  - isv.config
ms.assetid: b529c857-c2b9-4a02-9993-bd99008d7998
caps.latest.revision: 22
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Service calendar appearance configuration

You can control the appearance and behavior of the service calendar in the following ways:  
  
- [Set time block appearance](service-calendar-appearance-configuration.md#BKMK_TimeBlock)  
  
- [Set smooth scroll limit](service-calendar-appearance-configuration.md#BKMK_SmoothScrollLimit)  
  
- [Set validation chunk size](service-calendar-appearance-configuration.md#BKMK_ValidationChunkSize)  
  
  To edit these settings you must export the ISV.Config file by adding it as part of a solution, edit the `<IsvConfig>` element in the customizations.xml file, and then re-import and publish the solution. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Export the ISV.Config](service-calendar-appearance-configuration.md#BKMK_ExportISVConfig)  
  
<a name="BKMK_TimeBlock"></a>   
## Set time block appearance  
 You can control the appearance of the rendered blocks in the service calendar. You can control the color used to render the given entity type and status code.  
  
 Create a CSS web resource with a display name of “AppointmentBookConfig”. In the CSS web resource, define CSS classes using the following naming convention:  
  
 `[div.ganttBlock<entitylogicalname>Status<statuscode>]`  
  
 The following example shows how the CSS classes should be defined.  
  
```css  
div.ganttBlockserviceappointmentStatus1  
{  
    border: 1px solid #FF0000;  
    FILTER: progid:DXImageTransform.Microsoft.gradient(GradientType=0,startColorstr='#FF0000',endColorstr='#FF0000');  
    background: -moz-linear-gradient(top,  #FF0000 0%, #FF0000 100%);  
    background: -webkit-linear-gradient(top,  #FF0000 0%,#FF0000 100%);  
    background: -ms-linear-gradient(top,  #FF0000 0%,#FF0000 100%);  
    background: linear-gradient(top,  #FF0000 0%,#FF0000 100%);  
}   
  
div.ganttBlockserviceappointmentStatus2  
{  
    border: 1px solid #00FF00;  
    FILTER: progid:DXImageTransform.Microsoft.gradient(GradientType=0,startColorstr='#00FF00',endColorstr='#00FF00');  
    background: -moz-linear-gradient(top,  #00FF00 0%, #00FF00 100%);  
    background: -webkit-linear-gradient(top,  #00FF00 0%,#00FF00 100%);  
    background: -ms-linear-gradient(top,  #00FF00 0%,#00FF00 100%);  
    background: linear-gradient(top,  #00FF00 0%,#00FF00 100%);  
}  
  
div.ganttBlockserviceappointmentStatus3  
{  
    border: 1px solid #0000FF;  
    FILTER: progid:DXImageTransform.Microsoft.gradient(GradientType=0,startColorstr='#0000FF',endColorstr='#0000FF');  
    background: -moz-linear-gradient(top,  #0000FF 0%, #0000FF 100%);  
    background: -webkit-linear-gradient(top,  #0000FF 0%,#0000FF 100%);  
    background: -ms-linear-gradient(top,  #0000FF 0%,#0000FF 100%);  
    background: linear-gradient(top,  #0000FF 0%,#0000FF 100%);  
}   
  
div.ganttBlockserviceappointmentStatus4  
{  
    border: 1px solid #FFFF00;  
    FILTER: progid:DXImageTransform.Microsoft.gradient(GradientType=0,startColorstr='#FFFF00',endColorstr='#FFFF00');  
    background: -moz-linear-gradient(top,  #FFFF00 0%, #FFFF00 100%);  
    background: -webkit-linear-gradient(top,  #FFFF00 0%,#FFFF00 100%);  
    background: -ms-linear-gradient(top,  #FFFF00 0%,#FFFF00 100%);  
    background: linear-gradient(top,  #FFFF00 0%,#FFFF00 100%);  
}   
  
div.ganttBlockserviceappointmentStatus6  
{  
    border: 1px solid #FF00FF;  
    FILTER: progid:DXImageTransform.Microsoft.gradient(GradientType=0,startColorstr='#FF00FF',endColorstr='#FF00FF');  
    background: -moz-linear-gradient(top,  #FF00FF 0%, #FF00FF 100%);  
    background: -webkit-linear-gradient(top,  #FF00FF 0%,#FF00FF 100%);  
    background: -ms-linear-gradient(top,  #FF00FF 0%,#FF00FF 100%);  
    background: linear-gradient(top,  #FF00FF 0%,#FF00FF 100%);  
}   
  
div.ganttBlockserviceappointmentStatus7  
{  
    border: 1px solid #00FFFF;  
    FILTER: progid:DXImageTransform.Microsoft.gradient(GradientType=0,startColorstr='#00FFFF',endColorstr='#00FFFF');  
    background: -moz-linear-gradient(top,  #00FFFF 0%, #00FFFF 100%);  
    background: -webkit-linear-gradient(top,  #00FFFF 0%,#00FFFF 100%);  
    background: -ms-linear-gradient(top,  #00FFFF 0%,#00FFFF 100%);  
    background: linear-gradient(top,  #00FFFF 0%,#00FFFF 100%);  
}  
  
div.ganttBlockserviceappointmentStatus8  
{  
    border: 1px solid #7F7F7F;  
    FILTER: progid:DXImageTransform.Microsoft.gradient(GradientType=0,startColorstr='#7F7F7F',endColorstr='#7F7F7F');  
    background: -moz-linear-gradient(top,  #7F7F7F 0%, #7F7F7F 100%);  
    background: -webkit-linear-gradient(top,  #7F7F7F 0%,#7F7F7F 100%);  
    background: -ms-linear-gradient(top,  #7F7F7F 0%,#7F7F7F 100%);  
    background: linear-gradient(top,  #7F7F7F 0%,#7F7F7F 100%);  
}  
  
```  
  
<a name="BKMK_SmoothScrollLimit"></a>   
## Set smooth scroll limit  
 You can specify the limit when smooth scrolling is used based on the number of blocks rendered in the service calendar.  
  
 When the service calendar renders more blocks than indicated in the `SmoothScrollLimit` element, the behavior changes from scrolling to simply jumping to the first appointment. The service calendar automatically scrolls to the first appointment when it’s first displayed and when a row is selected.  
  
 To set this value, you must export the ISV.Config file as part of a solution and locate the `SmoothScrollLimit` element at `/ImportExportXml/IsvConfig/configuration/ServiceManagement/AppointmentBook/SmoothScrollLimit`.  
  
 The default value is 2000. You must edit the value, and the re-import and publish the solution before the change will take effect.  
  
<a name="BKMK_ValidationChunkSize"></a>   
## Set validation chunk size  
 You can specify the number of appointments or service activities that are passed to the server at a time to check for scheduling errors in the service calendar.  
  
 To set this value you must export the ISV.Config file as part of a solution and locate the `ValidationChunkSize` element at  `/ImportExportXml/IsvConfig/configuration/ServiceManagement/AppointmentBook/ValidationChunkSize`. This element isn’t included in the ISV.Config file by default so you must add it as a child of the `AppointmentBook` element.  
  
<a name="BKMK_ExportISVConfig"></a>   
## Export the ISV.Config  
 When you export a solution the **Export Solution** dialog box provides the **Export System Settings (Advanced)** option page. Select **ISV Config** as an option. The `IsvConfig` element will be included as a child of the `ImportExportXml` node.  
  
### See also  
 [Customize Entity Views](customize-entity-views.md)   
 [ISV Configuration File Schema](isv-configuration-file-schema.md)   
 [Customize Microsoft Dynamics 365 Customer Engagement](customize-applications.md)   
 [Create, Export, or Import an Unmanaged Solution](../create-export-import-unmanaged-solution.md)   
 [Support for Editing the Customization File](when-edit-customization-file.md)   
 [Publish Customizations](publish-customizations.md)   
 [ISV Configuration File Schema](isv-configuration-file-schema.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]