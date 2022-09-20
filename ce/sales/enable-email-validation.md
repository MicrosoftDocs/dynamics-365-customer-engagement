---
title: "Enable the detection of fake emails"
description: "Enable fake email detection to help sellers identify fake email addresses and keep the leads clean."
ms.date: 09/30/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Preview: Enable email validation

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Validate email addresses to lower email bounce rates by improving engagement rates for a better return on your invested time on leads.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## What is email validation?

The email validation feature analyzes the email addresses in the application and identifies fake emails that can't receive emails. The feature helps sellers to spend valuable time with reliable leads to improve their productivity.   

When you enable this feature, the application uses the following validations to identify fake email addresses: 

- **Incorrect syntax**: Validate email addresses for incorrect syntaxes. A valid email address consists of two parts &dash; a username and an email domain. For example, **kenny.smith@contoso.com** is a valid email. The email syntax contains both username (**kenny.smith**) and email domain (**contoso.com**), which is valid.   

- **Disposable domain**: Validate email address and identify disposable email domains that are temporary. For example, **john@yopmail.com**. The **yopmail.com** (email domain) is a known disposable email address domain.

- **Test or spam email addresses**: Validate email address for spamming-nature based on certain criteria such as, email header (or metadata), IP address, HTML code of the email, and email content and formatting. For example, **test@test.com** and **asdfasdf@asdf.asdf** email addresses are identified as spam. 

- **Expired email addresses**: Validate email address to verify if the email account is expired to receive or send emails. 

- **Emails that bounce back**: Validate email address to verify if the email address can't receive the message from the intended recipients for any reason.

Further, the email validation feature displays the fake emails to sellers on record forms and, work list items and the Up next widget in sales accelerator. More information: [Work with fake email addresses](work-fake-email-addresses.md)

>[!NOTE]
>- Currently, the email validation feature works only for lead records.
>- The email validation feature is not available on custom apps.
>- The email validation is applicable only for the primary email address.
>- The leads that are older than 180 days are not validated.

## Enable the email validation feature

1.	At the lower-left corner of the Sales Hub app, select **Change area** ![Change area icon](media/change-area-icon.png) > **App Settings**.
2.	On the site map, select **Data improvement** > **Email validation**.

    :::image type="content" source="media/lead-enable-email-validation-page.png" alt-text="Screenshot illustrating the email validation enablement page":::

3.	Turn on the email validation toggle.

    :::image type="content" source="media/lead-email-feature-enabled.png" alt-text="Screenshot illustrating the email validation feature is enabled":::

The application runs email validation on the existing primary email addresses for leads that are less than 180 days old and displays an alert (the Red envelop icon). Later, any new primary email address that comes into the application, goes through the validation check. 

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Work with fake email addresses](work-fake-email-addresses.md)
 