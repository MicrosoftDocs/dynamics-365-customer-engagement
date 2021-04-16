---
title: "Open the form editor (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 04/29/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: 8478a07a-c697-4784-874b-36958eb4f95d
caps.latest.revision: 63
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Open the form editor

 

 You can access the form editor in Dynamics 365 Customer Engagement (on-premises) through the command bar or the ribbon, depending on the entity. Both of these methods open the form in the context of the default solution. If you create any new solution components in the process of editing the form, for example web resources, the names of the components will use the solution publisher customization prefix for the default solution and these components will only be included in the default solution. If you want any new solution components to be included in a specific unmanaged solution, you should open the form editor through that unmanaged solution.  
  
## Access the form editor through the command bar  
> [!NOTE]
> Accessing the form editor through the command bar is only available in the classic web app.
  
1.  Open a record.  
  
2.  On the command bar, select **Form**, to open the form editor.  
  
## Access the form editor through the default solution  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2. Select **Customize the System** to open the default solution.  
  
3. Under **Components**, expand **Entities**, and then the entity you want, and select **Forms**.  
  
4. In the list of forms, select the form you want to edit.  
  
## Access the form editor for an unmanaged solution  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2. Select **Solutions**.  
  
3. Double-click the unmanaged solution you want to work with.  
  
4. Locate the entity with the form you want to edit. If the entity isn’t there, you’ll need to add it.  
  
### Add an entity to an unmanaged solution  
  
1.  Select the **Entities** node and, in the toolbar above the list, select **Add Existing**.  
  
2.  In the **Select Solution Components** dialog box, with the **Component Type** selector set to **Entity**, select the entity you want to add and select **OK**.  
  
3.  If the **Missing Required Components** dialog box appears, you can select **No, do not include required components** if you don’t intend to export this unmanaged solution to another organization. If you choose not to include missing required components at this time, you can add them later. You’ll receive notification again if you export this solution in the future.  
  
5.  In the solution explorer expand the entity with the form you want to edit and select **Forms**.  
  
6.  In the list of forms, double-click the form you want to edit.  
 
### See also
 [Work with the form editor](work-with-form-editor.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]