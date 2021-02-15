---
title: "Use HAT automation activities in Unified Service Desk | MicrosoftDocs"
description: "Learn how to use HAT automation activities to automate your hosted applications in Unified Service Desk."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Use HAT automation activities in Unified Service Desk
The [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)] provides you with a bunch of automation activities that you can use to automate your hosted applications. To view the [!INCLUDE[pn_hat](../includes/pn-hat.md)] automation activities in [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)]:  
  
1. Start [!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)], and create a Workflow Activity Library or open a Workflow Activity Library project. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [How to: Create an Activity Library](https://msdn.microsoft.com/library/dd489393\(v=vs.110\).aspx)  
  
2. If **Toolbox** is not visible in the workspace area, from the **View** menu, choose **Toolbox** to display it.  
  
3. In **Toolbox**, right-click and select **Choose Items**.  
  
   ![Select Choose Items in Toolbox](../unified-service-desk/media/usd-view-hat-activities-1.png "Select Choose Items in Toolbox")  
  
4. In the **Choose Toolbox Items** dialog box, on the **System.Activities Components** tab, click **Browse** to locate and select the Microsoft.UII.HostedApplicationToolkit.Activity.dll file. The file is available in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client installation directory (typically, C:\Program Files\Microsoft Dynamics CRM USD\USD) or in the *<UII_SDK_Extracted_Folder>*\UII\Bin folder.  
  
5. After you select the Microsoft.UII.HostedApplicationToolkit.Activity.dll file, the [!INCLUDE[pn_hat](../includes/pn-hat.md)] automation activities appear selected in the **Choose Toolbox Items** dialog box. Choose **OK** to display them in **Toolbox**.  
  
   ![HAT automation activities](../unified-service-desk/media/usd-hat-automation-activities-selected.png "HAT automation activities")  
  
6. Use the [!INCLUDE[pn_hat](../includes/pn-hat.md)] automation activities from **Toolbox** to design your workflow.  
  
   ![HAT automation activities in Toolbox](../unified-service-desk/media/usd-hat-automation-activities-toolbox.png "HAT automation activities in Toolbox")  
  
### See also  
 [Automate hosted applications using HAT automation activities](../unified-service-desk/automate-hosted-applications-using-hat-automation-activities.md)   
 [Types of HAT automation activities](../unified-service-desk/types-of-hat-automation-activities.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]