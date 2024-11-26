---
title: Set up Community forums
description: Learn how to configure a Community forum in Dynamics 365 Customer Service.
ms.date: 09/18/2024
ms.topic: article
author: lalexms
ms.author: laalexan
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Create a Community forum

In Customer Service Community, a forum is a container of ideas and the entity where security boundaries are applied. The user who creates a forum automatically becomes the owner and can assign community roles and membership in the forum, as well as other metadata, such as categories and groups.

## Create a forum

1.	On the navigation pane, select **Forum**, and then select **New**.
     > [!div class="mx-imgBorder"] 
     > ![Create a new Community forum.](../media/community-create-new-forum.png)

1.	Type a **Name**, then select the **Forum Settings** and **Website Settings** you want to apply to the forum. Your administrator manages these settings.
   
     > [!div class="mx-imgBorder"] 
     > ![Select forum and website settings.](../media/community-new-forum-details.png)
     
1.	Select the **Categories** tab, and then select **+ New Category**. Categories that you define here are available for end users to select when they create a new idea in this forum.
   
     > [!div class="mx-imgBorder"] 
     > ![Select the Categories tab.](../media/community-categories-tab.png)
     
1.	Type a **Name** for the category, and then select **Save**.

  	 > [!div class="mx-imgBorder"] 
     > ![Quick create details for a category.](../media/community-quick-create-category.png)
    
1.	To add more categories, repeat steps 3 and 4.

1.	When you're finished, select **Save and Close**.

1.	Go to the **Groups** tab, and then select **+ New Group**. The groups you define here are available for end users to select when they create a new idea in this forum.

1.	Type a group name, and then select **Save**.

1.	To add more groups, repeat steps 7 and 8.

1.	Go to the **Membership** tab to add members to your forums. You're already added as owner. The **Membership** tab is where you add forum owners and moderators.

1.	Select **+ New Forum Member**.
    
1.	In the **Role** dropdown menu, select **Owner** or **Moderator**, and then in **System User**, search and select the user you want.

1.	Select **Save**.
     > [!div class="mx-imgBorder"] 
     > ![Save your settings for the new member.](../media/community-quick-create-forum-member.png)

1.	To add other owners or moderators, repeat steps 11 through 13.

1.	(Skip this step if your forum is public.) If your forum is private (for example, accessible to "by-invitation" members only), you need to add those individuals as contacts. Select **+ New Forum Member**, select **Member** in **Role**, and then either search for the existing contact in **Contact** or add information for a new contact in **Contact Email**, **Contact First Name**, and **Contact Last Name**. Repeat this step to add all by-invitation members.
   
     > [!div class="mx-imgBorder"] 
     > ![Search for and select an existing contact or create a new one.](../media/community-select-create-contact.png)
     
1.	To publish your forum to the web, go to the **Web** tab, and then select **Yes** in the **Publish to web** dropdown menu.

  	 > [!div class="mx-imgBorder"] 
     > ![Select Yes to publish to the web.](../media/community-publish-settings.png)

1.	Under the **User Access Level**, select the access level for your users in public forums. The default values are **None** for all three configurations.
    **Important**: For private forums, leave the default settings set to **None**.
    - **Internal Authenticated Users**: Select the access level for users who are authenticated with email domains specified by your admin.
    - **External Authenticated Users**: Select the access level for non-internal authenticated users.
    - **Anonymous Users**: Select the access level for non-authenticated users.

1.	Go to the **Quick Links** tab to define links that appear for end-users in the forum. You can choose whether to include quick links that the admin added to the portal home page.

1.	To add a forum **Quick Link**, select **+ New Quick Link**, and then enter the following values:<br>
    - **Display Label**: Refers to how the link is displayed in the portal.<br>
    - **URL**: The webpage URL.<br>
    - **Description**: An optional field where you can provide additional information to describe this link to users.<br>
    - **Group label**: An optional field where you can specify the name of the group under which the link is listed.

  	 > [!div class="mx-imgBorder"] 
     > ![Add a forum quick link.](../media/community-forum-quick-link.png)
    
### Related information

[Community overview](community-overview.md)<br>
[Get started with Community](community-get-started.md)<br>
[Content moderation and management](community-moderator-experience.md)<br>
[Create new websites in Community](community-create-websites.md)<br>
[Community FAQs](community-faqs.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
