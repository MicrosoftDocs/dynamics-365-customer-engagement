---
title: Connect Gmail accounts by using OAuth 2.0 
description: Follow the steps in this article to set up server-side synchronization to send and receive email in Dynamics 365 Customer Engagement (on-premises) from Gmail accounts by using OAuth 2.0 as the authorization mechanism.
ms.custom: 
ms.date: 02/21/2023
ms.reviewer: sericks
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 
author: DanaMartens
ms.author: dmartens
search.audienceType: 
  - admin
---

# Connect Gmail accounts by using OAuth 2.0 

Follow the steps in this article to set up server-side synchronization to send and receive email in Dynamics 365 Customer Engagement (on-premises) from Gmail accounts by using OAuth 2.0 as the authorization mechanism.

> [!NOTE]
> The Gmail OAuth email server profile requires version 9.1 or later and works for up to 100 users. Create multiple OAuth profiles (steps 1 through 4) if you want to associate the same profile with multiple users.

## Step 1. Enable IMAP or POP in Gmail

> [!NOTE]
> These steps should be done by the system administrator.

For IMAP, follow the steps in [Check Gmail through other email platforms](https://support.google.com/mail/answer/7126229).

For POP, follow the steps in [Read Gmail messages on other email clients using POP](https://support.google.com/mail/answer/7104828).

## Step 2. Create a project

> [!NOTE]
> These steps should be done by the system administrator.

Using a Google account (this can be the same account you'll use to send and retrieve email, or a different account), go to the Google Developers Console and create a new project.

Follow the steps for **Create a project** in [Create, shut down, and restore projects](https://support.google.com/googleapi/answer/6251787).

## Step 3. Configure OAuth consent 

> [!NOTE]
> These steps should be done by the system administrator.

1. Select **OAuth consent screen**, and then select the user type:
   - Select **Internal** if you're using a GSuite admin tenant and will be creating the app exclusively for your organization.
   - Select **External** if you're testing by using a standalone Gmail account. 

2. Select **Create**.

3. Under **Application name**, enter the application name. Under **Authorized domains**, enter your environment's top private domain name (for example, `dynamics.com`). Select **Save**.

4. Select **Credentials** > **Create credentials**.

5. Select **OAuth client ID**.

6. Select **Configure consent screen**.

7. Enter the following settings:

   |Setting  |Use  |
   |---------|---------|
   |Application type     | Web application         |
   |Name     |  The name of your web client       |
   |Authorized JavaScript origins     | Your environment's  URL (for example, `https://contoso.crm.dynamics.com`)        |
   |Authorized redirect URIs     | Your environment's URL with `/_grid/cmds/dlg_gmailoauth.aspx` appended to it (for example, `https://contoso.crm.dynamics.com/_grid/cmds/dlg_gmailoauth.aspx`)        |

8. Select **Create**. In the screen that appears, make note of the client ID and client secret. You'll use this data in the next step.

## Step 4. Create an email server profile

> [!NOTE]
> These steps should be done by the system administrator.

1. In the upper-right corner of the web app, select **Settings**, and then select **Advanced settings**.

1. Go to **Settings** > **Email Configuration**.

1. Select **Email Server Profiles**.  

1. On the command bar, select **New** and then select **IMAP/SMTP Server**.

1. Specify a meaningful **Name** for the profile.

1. For **Incoming Server Location**, provide **imap.gmail.com**.	

1. For **Outgoing Server Location**, provide **smtp.gmail.com**.	

1. For **Authenticate Using**, select **Gmail OAuth**.

1. For **Client id** and **Client Secret**, enter the information you noted in step 8 of the previous procedure.

1. Expand **Advanced**, and then use the tooltips to choose your email processing options.

1. For **Incoming Port**, the port should be **993**.

1. For **Outgoing Port**, the port should be **587**. 

1. When you're done, select **Save**.


## Step 5. Configure the mailbox

> [!NOTE]
> These steps should be done by the mailbox user.

1. In the web app, go to **Settings** > **Advanced Settings**.

2. Select **Settings** > **Administration**.

3. Select **Settings** > **Email configuration** > **Mailboxes**.

4. Select the mailbox for the user configured in previous steps.

5. Use the following settings:

   |Setting  |Use  |
   |---------|---------|
   |Server profile    | The profile created in step 4     |
   |Incoming email    | Server-Side Synchronization or Email Router       |
   |Outgoing email | Server-Side Synchronization or Email Router   |

6. Select **Save**.

7. Select **Signin to Gmail**.

8. Proceed through the Gmail sign-in and authorization pages.

## Step 6. Add test users

> [!NOTE]
> These steps should be done by the system administrator.

In the Google Cloud Platform (Developer Console), add users in the **Test Users** section when publishing the app. More information: [Google Cloud Platform Console Help](https://support.google.com/cloud/answer/7454865)

## Step 7. Test and enable

> [!NOTE]
> These steps should be done by the mailbox user.

Select **Test & Enable Mailbox** to test the mailbox configured in step 6.
