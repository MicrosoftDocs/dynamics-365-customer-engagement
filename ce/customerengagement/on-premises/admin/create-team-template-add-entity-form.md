---
title: "Create a team template and add to an entity form  | MicrosoftDocs"
ms.custom: 
ms.date: 03/19/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
helpviewer_keywords: 
  - template
  - team template
  - team
ms.assetid: f02c1132-5d34-4956-83f6-220394d26d58
caps.latest.revision: 35
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin

---
# Create a team template to control access rights for automatically created teams

A team template can be used for the entities that are enabled for automatically created access teams. In the team template, you have to specify the entity type and the access rights on the entity record. For example, you can create a team template for an account entity and specify the Read, Write, and Share access rights on the account record that the team members are granted when the team is automatically created. After you create a team template, you have to customize the entity main form to include the new team template. After you publish customizations, the access team template is added in all record forms for the specified entity in a form of a list. For example, you created a team template called "Sales team" for the account entity. On all account record forms you'll see the list called "Sales team". You can add or remove team members using this list.  
    
<a name="bkmk_1"></a>   
## Enable an entity for access teams  
  
1. Make sure you have the System Administrator security role or equivalent permissions.
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3. In the **Customization** window, choose **Customize the System**.  
  
4. In the navigation pane, expand **Entities**, and then choose the entity you want to use in the team template.  
  
5. On the **Entity Definition** form, in the **Communication & Collaboration** section, select the **Access Teams** checkbox.  
  
6. On the **Actions** toolbar, choose **Save**.  
  
<a name="bkmk_2"></a>   

## Create a team template  
  
1. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
2. Choose **Access Team Templates**.  
  
3. On the **Actions** toolbar, choose **New**, complete the required fields, and then choose **Save**.  
  
> [!NOTE]
> You can only create two Access Team templates per entity.

<a name="bkmk_3"></a>  
 
## Add a team template to the entity form   
  
1. Make sure you have the System Administrator security role or equivalent permissions.
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3. In the **Customization** window, choose **Customize the System**.  
  
4. In the navigation pane, expand **Entities**, expand the entity you want to use in the team template, and then choose **Forms**.  
  
5. In **System Forms**, select **Active Forms** > **Main** form.  
  
6. On the **Main** form, open the **Insert** tab.  
  
7. On the ribbon, choose **Sub-Grid**.  
  
    The **Set Properties** dialog box appears.  
  
8. In **Set Properties**, complete the required fields, and then select the **Display label on the Form** check box.  
  
9. In the **Records** drop-down list, select **All Record Types**.  
  
10. In the **Entity** drop-down list, select **Users**.  
  
11. In the **Default View** drop-down list, select **Associated Record Team Members**.  
  
12. In the **Team Template** drop-down list, select the desired template and choose **Set**.  
  
     The team template you selected now appears on the **Main** form.  
  
13. On the **Actions** toolbar, click or tap **Save**, and then choose **Publish**.  
  
> [!NOTE]
> The Access Team template does not get exported with its entity in a Solution.  Administrators will need to recreate the template when exporting the entity into another instance.

### See also  
 [Manage teams](../admin/manage-teams.md)   
 [About team templates](../admin/about-team-templates.md)   


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]