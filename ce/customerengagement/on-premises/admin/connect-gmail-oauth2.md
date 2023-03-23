---
title: Connect Customer Engagement (on-premises) to Gmail accounts using OAuth 2.0 
description: Learn how to set up server-side synchronization to send and receive email in Dynamics 365 Customer Engagement (on-premises) from Gmail accounts using OAuth 2.0 as the authorization mechanism.
ms.custom: bap-template
ms.date: 03/23/2023
ms.reviewer: sericks
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: how-to
ms.assetid: 
author: DanaMartens
ms.author: dmartens
search.audienceType: 
  - admin
---

# Connect Customer Engagement (on-premises) to Gmail accounts using OAuth 2.0

Follow these steps to set up server-side synchronization to send and receive email in Dynamics 365 Customer Engagement (on-premises) from Gmail accounts using OAuth 2.0 as the authorization mechanism.

> [!NOTE]
> The Gmail OAuth email server profile requires version 9.1 or later and works for up to 100 users. Create multiple OAuth profiles to associate the same profile with multiple users.

Admins should perform the following steps:

1. [Turn on IMAP or POP in Gmail](#turn-on-imap-or-pop-in-gmail)
1. [Create a Google API Console project](#create-a-google-api-console-project)
1. Configure OAuth consent
1. Create an email server profile
1. Configure the mailbox
1. Add test users

A mailbox user should perform the following step:

- Test and enable

## Turn on IMAP or POP in Gmail

- IMAP: [Check Gmail through other email platforms](https://support.google.com/mail/answer/7126229)

- POP: [Read Gmail messages on other email clients using POP](https://support.google.com/mail/answer/7104828)

## Create a Google API Console project

[Create a project](https://support.google.com/googleapi/answer/6251787?ref_topic=7014522#zippy=%2Ccreate-a-project) in the Google API Console using either the Google account that will send and retrieve email or a different Google account.

## Set up OAuth consent

1. In the left navigation pane of the API Console, select **OAuth consent screen**.
1. Select the user type:
   - Select **Internal** if you're using a GSuite admin tenant and will be creating the app exclusively for your organization.
   - Select **External** if you're testing using a standalone Gmail account.
1. Select **Create**.
1. Enter the name of the app that's asking for consent.
1. Enter the support address your users should email if they have questions about their consent.
1. Under **Authorized domains**, select **ADD DOMAIN** and then enter your environment's top private domain name; for example, `dynamics.com`.
1. Under **Developer contact information**, enter your email address.
1. Select **SAVE AND CONTINUE**.
1. In the left navigation pane, select **Credentials**.
1. Select **CREATE CREDENTIALS** > **OAuth client ID**.
1. Select or enter the following values:

   | Setting | Use |
   |---------|-----|
   | Application type | Web application |
   | Name | The name of your web client |
   | Authorized JavaScript origins | Your environment's URL; for example, `https://contoso.crm.dynamics.com` |
   | Authorized redirect URIs | Your environment's URL with `/_grid/cmds/dlg_gmailoauth.aspx` appended to it; for example, `https://contoso.crm.dynamics.com/_grid/cmds/dlg_gmailoauth.aspx` |

1. Select **CREATE**.
1. Note the client ID and client secret that appear on the following page. You'll use them in the next step.

## Create an email server profile

1. Sign in to Dynamics 365 In the upper-right corner of the web app, select **Settings**, and then select **Advanced settings**.

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
