---
title: Work with invalid email addresses (preview)
description: View and work with invalid email addresses for leads and contacts in Microsoft Dynamics 365 Sales.
ms.date: 04/14/2023
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.custom: bap-template
---

# Work with invalid email addresses (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Email validation in Dynamics 365 Sales identifies and removes non-working or invalid email addresses in your leads and contacts. This proactive validation helps you prioritize customers who have a valid email address, which in turn results in lower email bounce rates, improved engagement, and increased value for your time.

Email address validation looks for the following errors:

- **Incorrect syntax**: An address that doesn't contain both a username and an email domain

- **Disposable domain**: An address that contains a known disposable or temporary email domain

- **Test or spam email addresses**: An address that contains known indicators of a test or spam address in the email header or metadata, IP address, HTML code of the email, and email content and formatting

- **Expired email addresses**: An email account that has expired and can no longer receive or send email

- **Emails that bounce back**: An address that can't receive a message for any reason

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/sales/relationship-sales/)<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as Salesperson or Sales Manager<br>More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## Prerequisite

Ask your administrator to turn on email validation for your organization. More information: [Enable email validation](enable-email-validation.md)

## View invalid email addresses

You can view invalid email addresses on primary record or sales insights forms, work list items, and the **Up next** widget in sales accelerator. A red envelope icon indicates an invalid email address.

### View invalid email addresses on primary entity and sales insights forms

Open a lead or contact record, and choose the primary record or sales insights form. In the following screenshot, a lead record has an invalid email address.

:::image type="content" source="media/lead-email-validation-primary-entity-form.png" alt-text="Screenshot showing an invalid email address in the primary lead entity form.":::

### View invalid email addresses on the Up next widget and work list items

Go to a record in sales accelerator with email as the current activity.

:::image type="content" source="media/lead-email-validation-worklist-upnext-wedget.png" alt-text="Screenshot showing an invalid email address in the work list item and Up next widget.":::

## Send an email to an invalid address

You can send a message to an email address that's marked as invalid. When you select the option to send email, a notification tells you the reason the email was marked as invalid. You can perform the following tasks in the notification:

- If you know the email address is valid, select **Mark valid**. The address is marked as valid and the alert is removed. Compose and send the email.

- If you don't know the email address is valid but you still want to send an email, select **Compose anyway**. Compose and send the email.

    :::image type="content" source="media/lead-email-validation-send-email-notification-message.png" alt-text="Screenshot of the notification that appears when you send email to an invalid address.":::

You can also send email to an invalid address by creating a manual email activity in the timeline.  

## Understand email error messages

| Error message | Description |
|---------------|-------------|
| This email doesn't seem to be valid as the domain expired recently | The email domain recently expired. We recommend you exercise caution while engaging with this email address. |
| This email doesn't seem to be valid as the domain has expired | The email domain has expired. We recommend you exercise caution while engaging with this email address. |
| This email doesn't seem to be valid as the domain is invalid | The email domain is misspelled or can't be found for some other reason. We recommend you exercise caution while engaging with this email address. |
| This email doesn't seem to be valid as it belongs to a temporary domain | The email domain is a known disposable or temporary domain. We recommend you exercise caution while engaging with this email address. |
| This email address may be invalid as it's a mailing list, and not an individual's email | The email address belongs to a mailing hub or hub email address, not to an individual. We recommend you exercise caution while engaging with this email address. |
| This email doesn't seem to be valid as the email address is malformed | The email address isn't in the expected format, *username@domain*. We recommend you exercise caution while engaging with this email address. |
| This email doesn't seem to be valid as the email address doesn't exist | The alias or username in this email address can't be found. We recommend you exercise caution while engaging with this email address. |
| This email doesn't seem to be valid as the domain is unknown | The email domain can't be found. We recommend you exercise caution while engaging with this email address. |
| This email seems to be spam | The email address or domain is a known source of spam. We recommend you avoid engaging with this email address. |
| This email seems to be fake | The email address has a fraught alias. We recommend you avoid engaging with this email address. |

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Enable email validation](enable-email-validation.md)
