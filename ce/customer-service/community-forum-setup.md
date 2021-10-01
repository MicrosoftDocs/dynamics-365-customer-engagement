---
title: Set up Community forums | MicrosoftDocs
description: Learn how to configure a Community forum in Dynamics 365 Customer Service
ms.date: 10/04/2021
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Preview: Create a Community forum

> [!IMPORTANT]
>
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>
> [!INCLUDE[cc-preview-features-send-us-feedback](../includes/cc-preview-features-send-us-feedback.md)]


In Customer Service Community, a forum is a container of ideas and the entity where security boundaries are applied. The user who creates a forum automatically becomes owner, and can assign community roles and membership in the forum, as well as other metadata, like categories and groups.

## Create a forum

1.	On the left-side navigation panel, select **Forum**, and then select **New**.
2.	Enter a **Name** (required), and then select **Forum Settings** and **Website Settings**. Settings are managed by your administrator.
3.	Select the **Categories** tab, and then select **+ New Category**. the categories you define will be available for end-users to select when they create a new idea in this forum.
4.	Enter a **Name** for the category, and then select **Save**.
5.	To add more categories, repeat steps 4 and 5 above..
6.	Go to the **Groups** tab and select **+ New Group**. The groups you define here will be available for end-users to select when they create a new idea in this forum.
7.	Enter a group name, and then select **Save**.
8.	To add more groups, repeat steps 7 and 8 above.
9.	Go to the **Membership** tab to add members to your forums. You'll see that you are already added as owner. The **Membership** tab is where you add individual forum owners and moderators.
10.	Select **+ New Forum Member**.
11.	In the **Role** dropdown menu, select **Owner** or **Moderator**, then in **System User**, search and select the user you want.
12.	Select **Save**.
13.	To add other owners or moderators, repeat steps 11-13.
14.	(Skip this step if your forum is public.) If your forum is private, only accessible to "by-invitation" members, you'll need to add those individuals as contacts. In **Role**, select **Member** or create a contact. Repeat this step to add all by-invitation members.
15.	To publish your forum to the web, go to the **Web** tab, and then select **Yes** from the **Publish to web** dropdown menu.
16.	Under the **User Access Level**, select the access level for your users in public forums. The default values are **None** for all three configurations.
    **Important**: For private forums, leave the default settings set to **None**.
    - **Internal Authenticated Users**: Select the access level for users who are authenticated with email domains specified by your admin.
    - **External Authenticated Users**: Select the access level for non-internal authenticated users.
    - **Anonymous Users**: Select the access level for non-authenticated users.
17.	Go to the **Quick Links** tab to define links that show to end-users in the forum. You can choose whether to include quick links that the admin added to the portal home page.
18.	To add a forum **Quick Link**, select **+ New Quick Link**, and then enter the following values:
    **Display Label**: Refers to how the link will be displayed in the portal.
    **URL**: The webpage URL.
    **Description**: An optional field where you can provide additional information to describe this link
    **Group label**: The name of the group under which the link will be listed in the portal.
    
### See also

[Community overview](community-overview.md)<br>
[Get started with Community](community-get-started.md)<br>
[Content moderation and management](community-moderator-experience.md)<br>
[Community FAQs](community-faqs.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
