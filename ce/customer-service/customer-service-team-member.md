---
title: Customer Service Team Member app | Microsoft Docs
description: Customer Service Team Member app
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 02/03/2020
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
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
# Preview: Customer Service Team Member app

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../legal/dynamics-insider-agreement.md).

With the entry-level Team Member license, you can now address self-service support scenarios for your employees using a Dynamics 365 Customer Service app. The employees can search the knowledge base for solutions pertaining to their problems, such as laptop issues, HR queries, and administrative needs. The employees can create cases and interact with agents through the comments feature.

The Customer Service Team Member app is a new  module that will be available to you with the Dynamics 365 Team Member license.

## Install Customer Service Team Member app

The Customer Service Team Member app must be manually installed in your instance and the **Customer Service Team Member** role assigned to the users before they can access it.

1. As an administrator, sign in to Dynamics 365 Administration Center, and select **Manage Solutions**. The **Manage your Dynamics 365 instances** page appears.
2. Select the instance in which you want to install the Team Member app, and select the edit icon beside **Solutions**. The **Manage your solutions** page appears.
3. Select **Customer Service Team Member Anchor**, and select **INSTALL**. The solution is installed and the **STATUS** column in the table displays "Installed".
4. Grant the **Customer Service Team Member** role to the users who will access the app. To learn about granting the role, see [Assign a security role to a user](/power-platform/admin/create-users-assign-online-security-roles#assign-a-security-role-to-a-user).

## Change the default account

You can update the default account that is configured for employees when they create a case. Perform the steps outlined in this section to associate a different account as the default account.


## Use the Customer Service Team Member app

In the Customer Service Team Member app, you can perform the following tasks:

- Create cases, read, and update the cases that you created.
- Use the comments feature for your cases to interact with agents.
- Search and view knowledge articles.

1. Sign in to Dynamics 365, and select **Customer Service Team Member**.
2. Select **Cases**. The **Active Cases created by me** page appears.
3. Select **New Case**. The **New Case** page appears.
4. Enter the following details on the **Summary** tab:

     - **Case Title:** Specify a title.
     -  **Subject:** Specify the subject.
     -  **Product:** Select the product category.
     -  **Description:** Specify a description that summarizes the problem.

    > [!NOTE]
    > The **Customer** value is not available for editing.

5. Select **Save**. The **Comments** section appears on the page that can be used to provide additional information.
6. Select **New Comment**. The **New Comment** page appears.
7. In **General** > **Description**, enter additional information that would be useful in addressing the problem.
8. Select **Save**. The **Timeline section is enabled where you can add notes and upload files pertaining to the problem.**
  
    > [!div class="mx-imgBorder"]
    > ![New comment](media/cstm-new-comment.png "New comment")

9. (Optional.) Select Enter a note to add notes and attach files.
10. Select **Save & CLose**. The **Active Cases created by me** page appears.
11. Select **Knowledge Search** to search for articles pertaining to your problem area that may help in addressing the issue.

