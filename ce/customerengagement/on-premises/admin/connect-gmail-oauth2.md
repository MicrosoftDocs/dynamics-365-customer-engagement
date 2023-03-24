---
title: Connect Customer Engagement (on-premises) to Gmail accounts using OAuth 2.0 
description: Learn how to set up server-side synchronization to send and receive email in Dynamics 365 Customer Engagement (on-premises) from Gmail accounts using OAuth 2.0 as the authorization mechanism.
ms.custom: bap-template
ms.date: 03/24/2023
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

An admin should perform the following procedures:

1. [Turn on IMAP or POP in Gmail](#turn-on-imap-or-pop-in-gmail)
1. [Create a Google API Console project](#create-a-google-api-console-project)
1. [Set up OAuth consent](#set-up-oauth-consent)
1. [Create an email server profile](#create-an-email-server-profile)

A mailbox user should perform the following procedure:

- [Set up and test the mailbox](#set-up-and-test-the-mailbox)

## Turn on IMAP or POP in Gmail

- IMAP: [Check Gmail through other email platforms](https://support.google.com/mail/answer/7126229)

- POP: [Read Gmail messages on other email clients using POP](https://support.google.com/mail/answer/7104828)

## Create a Google API Console project

[Create a project](https://support.google.com/googleapi/answer/6251787?ref_topic=7014522#zippy=%2Ccreate-a-project) in the Google API Console using the Google account that will send and retrieve email.

## Set up OAuth consent

1. In the left navigation pane of the API Console, select **OAuth consent screen**.
1. Select the user type:
   - Select **Internal** if you're using a GSuite admin tenant and are creating the app exclusively for your organization.
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
1. Note the client ID and client secret that appear on the following page. You'll use them in the next procedure.

    You can also find the client ID and secret under **Credentials** in the API Console.

1. Under **Test users**, select **ADD USER**. Add a Gmail account to test the app with and remember to publish the app after you've tested and turned on the mailbox. Or, publish the app now and any Gmail account can be used to test with.

## Create an email server profile

1. Sign in to Customer Engagement (on-premises). In the upper-right corner of the web app, select the **Settings** gear icon, and then select **Advanced settings**.

1. Select the arrow next to **Settings**, and then select **Email Configuration**.

1. Select **Email Server Profiles**.  

1. Select the arrow next to **New**, and then select **IMAP/SMTP Server**.

1. Enter a meaningful **Name** for the new profile.

1. For **Incoming Server Location**, enter **imap.gmail.com**.

1. For **Outgoing Server Location**, enter **smtp.gmail.com**.

1. For **Authenticate Using**, select **Gmail OAuth**.

1. For **Client Id** and **Client Secret**, enter the information you noted in the previous procedure.

1. Expand **Advanced**.

1. For **Incoming Port**, enter **993**.

1. For **Outgoing Port**, enter **587**.

1. Select **Save & Close**.

## Set up and test the mailbox

1. Sign in to Customer Engagement (on-premises). In the upper-right corner of the web app, select the **Settings** gear icon, and then select **Advanced settings**.

1. Select the arrow next to **Settings**, and then select **Email configuration** > **Mailboxes**.

1. Select and edit the mailbox to be used for server-side sync with Gmail.

1. For **Server Profile**, select the email server profile that's associated with Gmail OAuth, created in the previous procedure.

1. Make sure that both **Incoming Email** and **Outgoing Email** are set to **Server-Side Synchronization or Email Router**.

1. Select **Save**.

1. Select **SignIn to Gmail**. Sign in to and authorize the Gmail account you're using to test with.

1. Select **Save & Close**.

1. Select the mailbox, and then select **TEST & ENABLE MAILBOX**.

1. Under **Test Email Configuration**, select which mailboxes to test. Select **OK** to run the test.

    You can view the results in the mailbox list or in the mailbox record.
