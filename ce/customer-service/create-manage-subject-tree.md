---
title: Create and manage subject tree (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to create and manage subject tree in Dynamics 365 Customer Service
ms.date: 08/01/2023
ms.topic: article
author: neeranelli
ms.author: nenellim
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Create and manage subjects in a subject tree

Dynamics 365 Customer Service includes a subject organizational structure that lets you group service cases and knowledge base articles. By using the subject hierarchy, you can classify service cases to quickly provide service to your customer.

The search control for the subject tree entity is available by default for out-of-the-box and custom forms. If you'd like to disable the search control, please contact Microsoft support.

> [!NOTE]
> The availability of search control by default is an early access feature. You can opt in early to enable these features in your environment, which will allow you to test these features and then adopt them across your environments. For information about how to enable these features, see [Opt in to early access updates](/power-platform/admin/opt-in-early-access-updates).
  
## Create or edit a subject

[!INCLUDE[proc_permissions_custsvcmgr_sysadmin_and_customizer](../includes/proc-permissions-custsvcmgr-sysadmin-and-customizer.md)]  

You can create or edit a subject in the Customer Service admin center or Customer Service Hub app.

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Case Settings** in **Customer Support**. The **Case Settings** page appears.
     1. In the **Subjects** section, select **Manage**.

   ### [Customer Service Hub](#tab/customerservicehub)
    
     1. In the site map, select **Service Management**.
     2. Select **Subjects** in **Case Settings**. 
  
2. On the **Subject tree** page, in the **Subject tree management** area, select **Add**.  
  
3. In the **Create a subject** dialog, enter the following information:  
  
    - **Title**: Type a name for the subject.
  
    - **Parent subject**: Search for and select a parent subject. Leave it blank if you want the new subject to be a parent subject.
  
    - **Description**: Type a descriptive statement about the subject.
    
    - Set the toggle for **Visibility** to **Yes** if you want the subject to be available for the agent.

    :::image type="content" source="media/create-subject.png" alt-text="Create a subject.":::

4. Select **Save and close**.

5. To edit a subject, select a subject, and then select **Edit**. You can also select **More commands** to display the actions, such as **Edit** or **Add**, that you can take for the selected subject.

    > [!NOTE]
    > If you select a subject in the subject tree and select **Add**, clear the selection in the **Parent subject** box to make it a parent subject. Otherwise, the new subject will be added as a child of selected subject.

## Delete a subject  

To delete a subject from the subject tree, select the subject and select **Delete**.

## Manage the subject tree

The following options are available for subjects:

- **Users can only select subjects without children in the subject tree**: Turn on the toggle to **On**. At runtime, users will be able to select only those subjects that don't have child subjects. This setting allows administrators to make sure that agents select only specific subjects.
- **Show hidden subjects in the subject tree below**: Set the toggle to **Show**. In the subject tree, the subjects that are marked as hidden are displayed with the hidden icon. This setting allows administrators to preview the runtime functionality of the visibility of subjects to agents.
- **Search**: Use the search option to search for a subject by name and perform the different actions that are allowed for the subject. The subject that you search fo is highlighted and displayed in the subject tree. This setting allows you to easily locate the subject and child subjects instead of manually scrolling through the subject list.

    :::image type="content" source="media/using-subject-management.png" alt-text="Subject management at a glance.":::

You can select **Open old subject management page** to use the older experience. However, to revert to the new experience, you'll need to navigate to **Subjects** from the site map.

> [!NOTE]
> We recommend that you create not more than 1,000 subjects including child subjects to avoid performance issues.

### See also

[Configure Customer Service](configure-cs.md)  
[Overview of case management](overview-cases.md)  
[Enable search control for the subject entity](search-control-for-subjects.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
