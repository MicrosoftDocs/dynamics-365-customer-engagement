---
title: "Troubleshooting guide for Dynamics 365 Sales Professional | MicrosoftDocs"
description: "Follow the instructions in this topic to troubleshoot the issues your users may face while working on Dynamics 365 Sales."
ms.date: 02/10/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Dynamics 365 Sales Professional troubleshooting guide

Use the following list of troubleshooting topics to quickly find information to solve your users' issues.

## Trial signup

### I'm not able to sign up for Sales Professional trial

If your Microsoft 365 tenant administrator has disabled trial signup for your organization, you'll see the error message "Your IT department has turned off signup for Dynamics 365 Sales Professional Trial. Contact them to complete signup." 

Please contact your IT department and work with them to help you sign up. 

### I see the error while signing up: "Something went wrong building your Sales Pro experience. Do you want to try again?"

**Reason:**

There could be multiple reasons for this error:

- You've already signed up for the Sales Professional application for his tenant and are trying again with other credentials for the same tenant before the first trial instance expiry.

- You aren't using the complete sign-up URL and using reply URL present in sign-up URL. For example, you're using https://salesprotrial.dynamics.microsoft.com  instead of https://signup.microsoft.com/Signup?sku=9c7bff7a-3715-4da7-88d3-07f57f8d0fb6&RU=https://salesprotrial.dynamics.microsoft.com.

- The Sales Professional trial license that's assigned to you as part of the sign-up process isn't synced with Azure Active Directory.

**Workaround:**

Try the following steps to resolve this issue:

1. Clear your browser cache, and close the browser.

2. Wait for at least 5 minutes, and then open the browser in a private browsing mode.

3. Use the full [sign-up URL](https://signup.microsoft.com/Signup?sku=9c7bff7a-3715-4da7-88d3-07f57f8d0fb6&RU=https://salesprotrial.dynamics.microsoft.com).


### See also

[Sign up for a free trial of Dynamics 365 Sales Professional](try-dynamics365-sales-professional.md)t