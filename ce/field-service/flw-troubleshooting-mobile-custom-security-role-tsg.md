---
title: The mobile app shows an error on start due to permission/privilege issues
description: 
ms.date: 09/14/2023
ms.topic: troubleshooting
author: andrea-orimoto
ms.author: andreo
ms.reviewer: mhart
ms.custom: bap-template
---

# The mobile app shows an error on start due to permission/privilege issues

The new user experience for Field Service Mobile (preview) requires a few additional privileges added to the security roles which the user belongs to.

## Prerequisites

Administrator permissions in Dynamics 365 Field Service (Preview).

## Symptoms

The Field Service Mobile app fails to launch with the following error: `Principal user (Id=<GUID>, …) is missing 'prvReadmsdyn_Mobile' privilege (Id=<GUID>) on OTC=<INT> for entity 'msdyn_mobilesource' …`

## Resolution

The new experience for Field Service Mobile requires additional privileges for users' security roles. The system automatically adds these privileges to all default security roles. If your organization uses custom security roles, you need to update them by adding the following privileges:

- Name=`"msdyn_richtextfile"` Permission="Create" Value="User"
- Name=`"msdyn_richtextfile"` Permission="Delete" Value="User"
- Name=`"msdyn_richtextfile"` Permission="Read" Value="User"
- Name=`"msdyn_richtextfile"` Permission="Write" Value="User"
- Name=`"msdyn_MobileSource"` Permission="Read" Value="Organization"
- Name=`"msdyn_solutioncomponentsummary"` Permission="Read" Value="Organization"
- Name=`"SettingDefinition"` Permission="Read" Value="Organization"
- Name=`"Solution"` Permission="Read" Value="Organization"
- Name=`"SettingDefinition"` Permission="Read" Value="Organization"

### How to update security roles

1. Sign in to [Power Platform admin center](https://admin.powerplatform.microsoft.com/) with admin credentials.

1. Go to **Environments**, select your environment, and select **Settings**.

1. If you don't know the name of the custom security role, expand **Users + permissions**, select **Users** and look for the user that is reported seeing the error message. Note the of the user's security roles.

1. Go to **Settings** > **Users + permissions** > **Security roles**

1. For all the custom security roles you noted, do the following steps:

   1. Select the custom security role.
   1. On the **Tables** tab, choose **Show all tables** from the drop-down.

      ![Screenshot 2023-09-12 at 10.44.56 AM.png](/.attachments/Screenshot%202023-09-12%20at%2010.44.56%20AM-ecc1eb59-6b15-4c1d-9387-e707ac78259f.png)
   1. Set all privileges in this list, make sure that its value is set accordingly:

        - Name=`"msdyn_richtextfile"` Permission="Create" Value="User"
        - Name=`"msdyn_richtextfile"` Permission="Delete" Value="User"
        - Name=`"msdyn_richtextfile"` Permission="Read" Value="User"
        - Name=`"msdyn_richtextfile"` Permission="Write" Value="User"
        - Name=`"msdyn_MobileSource"` Permission="Read" Value="Organization"
        - Name=`"msdyn_solutioncomponentsummary"` Permission="Read" Value="Organization"
        - Name=`"SettingDefinition"` Permission="Read" Value="Organization"
        - Name=`"Solution"` Permission="Read" Value="Organization"
        - Name=`"SettingDefinition"` Permission="Read" Value="Organization"

       For example: Privilege: `"Create"` with Value: `"User"`. Go to the column that shows "Create" and change the dropdown to the value needed that in this case is `"User"`.

       ![Screenshot 2023-09-11 at 9.22.37 PM.png](/.attachments/Screenshot%202023-09-11%20at%209.22.37%20PM-59a57371-78f9-4cf5-a228-64c1e6c644ca.png)


<!-- add links to PPAC docs for custom roles and permissions -->