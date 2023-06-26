---
title: Enable email validation (preview)
description: Enable email validation for leads and contacts in Microsoft Dynamics 365 Sales to help your sellers keep their customer email addresses clean.
ms.date: 05/23/2023
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.custom: bap-template 
---

# Enable email validation (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Enable email validation in Dynamics 365 Sales to remove invalid email addresses from your lead and contact records. You'll reduce email bounce rates, improve engagement, and get a better return on your sellers' time. 

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/sales/relationship-sales/)<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Prerequisite

Before you enable the email validation feature, ensure that the **AI Builder preview models** option is enabled in your organization. More information: [How do I enable a Preview feature?](/power-platform/admin/what-are-preview-features-how-do-i-enable-them#how-do-i-enable-a-preview-feature)

## In which regions is email validation available?

Email validation is available in the following regions:

- Asia Pacific (APAC)
- Canada (CAN)
- Europe (EUR)
- France (FRA)
- Great Britain (GBR)
- India (IND)
- Japan (JPN)
- North America (NAM)
- Oceania (OCE)
- South America (SAM)
- Switzerland (CHE)
- United Arab Emirates (UAE)

## What is email validation?

Email validation analyzes the primary email address in lead and contact records to identify the ones that can't receive email. You must enable the feature. It's turned off by default. 

Email address validation looks for the following issues:

- **Incorrect syntax**: An address that doesn't contain both a username and an email domain
- **Disposable domain**: An address that contains a known disposable or temporary email domain
- **Test or spam email addresses**: An address that contains known indicators of a test or spam address in the email header or metadata, IP address, HTML code of the email, and email content and formatting
- **Expired email addresses**: An email account that has expired and can no longer receive or send email
- **Emails that bounce back**: An address that can't receive a message for any reason

Sellers can view invalid email addresses on record forms, work list items, and the **Up next** widget in sales accelerator. More information: [Work with invalid email addresses](work-invalid-email-addresses.md)

## Difference between Dynamics 365 Sales and Power Apps 

The email validation feature in Dynamics 365 Sales and Power Apps works on the same principles. However, there are some differences as listed below: 

| Scenario | Dynamics 365 Sales | Power Apps|
|------|--------------------|-----------|
| **Validation** | The validation process runs every six hours and targets only the primary email address in lead and contact records.<br>The feedback is displayed each time the form is loaded.<br> More information: [View invalid email addresses](work-invalid-email-addresses.md#view-invalid-email-addresses) | The validation process dynamically runs on all email address fields, providing immediate feedback. <br>Also, validations are not performed on addresses that are bulk imported. |
| **Actions** | Users can mark the invalid email addresses as valid.<br> More information: [Send an email to an invalid address](work-invalid-email-addresses.md#send-an-email-to-an-invalid-address) | Users can't mark the invalid email addresses as valid. |
| **Both features enabled in an organization** | Only the primary email addresses of leads and contacts are validated according to the Dynamics 365 Sales implementation. | All other email addresses are validated based on the Power Apps implementation. |

>[!NOTE]
>To know more about the email validation feature in Power Apps, see [Email address validation for email columns](/power-apps/maker/data-platform/data-validation-email-column).        

## Limitations of email validation

- Email validation works only for lead and contact records.
- It checks only the primary email address in lead and contact records.
- Leads and contacts that are older than 180 days aren't validated.

## Enable email address validation

1. In the Sales Hub site map, select **Change area** > **App settings** > **Data improvement** > **Email validation**.

    :::image type="content" source="media/lead-enable-email-validation-page.png" alt-text="Screenshot of the email validation page.":::

1. Turn on email validation for leads and contacts, according to your requirements.

Email validation runs on the primary email address in lead and contact records that are less than 180 days old. Subsequently, the validation runs once in every 6 hours. A red envelope icon indicates an invalid email address. 

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Work with invalid email addresses](work-invalid-email-addresses.md)   
[Enable email validation for custom forms](enable-email-validation-custom-forms.md)  
