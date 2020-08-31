---
title: "App profile manager | MicrosoftDocs"
description: "Using app profile manager to create and manage app profiles."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/28/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Preview: Create and use app profiles to manage apps

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - This feature is a preview, which means that it is made available to you before general availability so you can test and evaluate the preview and provide feedback to Microsoft.
> - This preview may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, this preview is not meant to be used with any "live" or production Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Any use of "live" data is at your sole risk and it is your sole responsibility to notify your end users that they should not include sensitive information with their use of the Preview.
> - This preview, and any support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty. This preview is subject to the [Preview Terms](../legal/supp-dynamics365-preview.md).

## Introduction

This topic discusses how to use the app profile manager to create app profiles and assign them to users.

By default, the following app profiles are available out of the box for Customer Service workspace and Omnichannel for Customer Service. These profiles can't be deleted or modified. When no app profile is assigned to an agent, the default profile is assigned.

- Omnichannel for Customer Service - default profile
- Customer Service workspace - default profile
<!-- [kabala] - The name of the app profile for CSW is wrong. It must be Customer Service workspace - default profile. Also, mention that the OC app profile will be available only customers buy either Chat for D365 or Digital messaging SKU.-->

## Prerequisites

To create app profiles for Omnichannel for Customer Service, you must have Chat for Dynamics 365 license.
<!-- [kabala] - Pre-req is the security role. See the App profile manager topic to learn about the security roles.-->

## Create an app profile

1. Sign in to Power Apps.
<!-- [kabala] -Steps missing on the entry point from the apps. -->
2. On the App profiles page, select **New profile**.
3. On the **New profile** pane, specify the following:
   - **Name:** The app profile name.
   - **Unique name:** A unique identifier in the *<prefix>*_*<name>* format.
     > [!IMPORTANT]
     > The following are required for the unique name:
     > - The prefix can only be alphanumeric and its length must be between 3 to 8 characters.
     > - An underscore must be there between the prefix and name.
   - **Description:** A description for the profile.
<!-- [kabala] - Update a note if the the unique name is incorrect, there may no error message. Update the unique name as per the requirement and try again.-->
  
### Add templates and enable productivity pane and channels

1. On the **App profiles** page, select the app profile to which you want to assign templates.
2. On the **Session templates**, select **Add entity session template**.
3. Search for the template you want to add and select it. Make sure that the selected template is based on **Entity** type. More information: [Manage session templates](session-templates.md)
   > [!div class=mx-imgBorder]
   > ![App profile session template](media/app-profile-session-template.png "App profile session template")
   
   <!-- [kabala] - 1. Make it explicit with the that admins can't add session templates of type - Generic. 2. Also, add another note that only one session template per entity can be added. For example - one case entity session template, account, contact, work order, and so on. If admins add any session template of the entity type more than once, then the first entity session template will be considered for initating a session in the runtime. For example, you add **Case entity template - 1** and **Case entity template - 2** in the same order, then for initiating a session, **Case entity template - 1** will be considered. It is recommended that you add one session template per entity per app profile.-->
   
4. Do the following on the **Productivity pane** tab:
   1. If you want to enable productivity tools, set the toggle to on for **Turn on productivity pane**.
   2. Select the default mode as collapsed or expanded.
   3. In the **Productivity tools** section, set the toggle to on for **Smart assist tool configuration** and **Agent scripts** to allow access to smart assist configuration and agent scripts. <!-- [kabala] - Smart assist tool name is not correct. Also, for new app profiles SA might not. Pls reach out to Neerja Rewal/Sarang Suneri to get more clarity on the Smart assist behavior with new App profiles.-->
5. On the **Channels** tab, set the toggle to on for **All active channels**. The channels configured in Omnichannel for Customer Service will be available for the user to whom the profile is assigned. <!-- [Kabala] - Add a note. For channel realated configuration such channels, workstreams, a session and notification templates, admins need to configure them in OC admin app. Give a link to OC admin app-->

   > [!NOTE]
   > The toggle for channels will be enabled in the out-of-the-box app profile for Omnichannel for Customer Service.

6. To add a third-party channel provider, in the **Voice channels** section, select **Add channel providers**, search for the configured channel, and select it.
7. If a channel does not exist, select **Create a new channel provider in Unified Interface**. The channel configuration page opens on a new tab. More information: [Configure channel provider using app profile manager](..customer-service/channel-integration-framework/v2/configure-channel-provider-app-profile-manager)

<!-- [Kabala] - Add a note. Only telephony or voice channels are supported for integration.-->
  
### Assign profiles to users

1. On the **App profiles** page, select the profile that you want to assign to a user.
2. On the ***<profile_name>*** page, select **Assign users** on the command bar, and select **OK** on the message dialog box. The profile opens on a new tab.
   > [!div class=mx-imgBorder]
   > ![Assign users](media/assign-users.png "Assign users")
3. On the **General** tab, select **Add Existing User**.
4. On the **Lookup Records** pane, search and select the user.
5. Select **Add**.

### Default profile assignment

<!-- [kabala] - Every user (agent or supervisor) of CSW or OCS should have an app profile. However, if any user doesn't have an app profile assigned to them, then based on the security roles, we pick an app profile. If the user has a custom role, then we will provide CSW OOB ap profile->

When users are assigned roles corresponding to Customer Service workspace or Omnichannel for Customer Service, the default app profiles are assigned as follows.

- **Customer Service workspace:** The out-of-the-box app profile is assigned to users with the following roles:
  - CSR Manager
  - Customer Service Representative
- **Omnichannel for Customer Service:** The out-of-the-box app profile is assigned to users with the following roles:
  - Omnichannel administrator
  - Omnichannel supervisor
  - Omnichannel agent

### See also

[Manage session templates](session-templates.md)  
[Configure channels](../omnichannel/administrator/channels.md)  
[Manage agent scripts](agent-scripts.md)
