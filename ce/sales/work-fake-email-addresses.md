---
title: "Work with fake email addresses"
description: "Find and work on fake email addresses using the email validation feature in Dynamics 365 Sales."
ms.date: 09/09/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Preview: Work with fake email addresses

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Identifying and prioritizing the lead records with a valid email address to lower email bounce rates, improve engagement, and a better return on your invested time.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as Salesperson or Sales Manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## Prerequisite

Contact your administrator to enable the email validation feature for your organization. More information: [Enable email validation](enable-email-validation.md) 

## Criteria to identify fake email addresses

Fake email addresses are identified based on the following criteria: 

- **Incorrect syntax**: Validate email addresses for incorrect syntaxes. A valid email address consists of two parts &dash; a username and an email domain. For example, **kenny.smith@contoso.com** is a valid email. The email syntax contains both username (**kenny.smith**) and email domain (**contoso.com**), which is valid.   

- **Disposable domain**: Validate email address and identify disposable email domains that are temporary. For example, **john@yopmail.com**. The **yopmail.com** (email domain) is a known disposable email address domain.

- **Test or spam email addresses**: Validate email address for spamming-nature based on certain criteria such as, email header (or metadata), IP address, HTML code of the email, and email content and formatting. For example, **test@test.com** and **asdfasdf@asdf.asdf** email addresses are identified as spam. 

- **Expired email addresses**: Validate email address to verify if the email account is expired to receive or send emails. 

- **Emails that bounce back**: Validate email address to verify if the email address can't receive the message from the intended recipients for any reason.

## View the fake email address

The email validation is performed on the leads records when the administrator enables the feature. The lead records start displaying an alert (the Red envelop icon) beside the primary email address, if the email validation feature identifies the email to be fake. You can view the validations on primary entity form and, up next widget and work list item in sales accelerator. 

**On a primary entity form**

Open a record and choose the primary record form. In this example, a lead record is opened and the **Lead** form is selected. For this record, you can observe that an alert is displayed beside the primary email address specifying that the email address is fake.

:::image type="content" source="media/lead-email-validation-primary-entity-form.png" alt-text="Screenshot illustrating the email is fake in the primary lead entity form"::: 

**On the up next widget and work list item**

Go to a record in sales accelerator with email as the current activity. In this example, a lead record is selected with the current activity as email. Here, you can observe that the work list item and the Up next widget display the alert, specifying that the email linked the record is fake.  

:::image type="content" source="media/lead-email-validation-worklist-upnext-wedget.png" alt-text="Screenshot illustrating the email is fake in the work list item and up next widget for a record":::

## Can I send an email? 

Yes, you can still choose to send a message to the email address that is flagged as fake. Select the option to send email and a notification message is displayed stating that the reason why the email is flagged as fake. You can perform the following tasks on the notification message dialog:

- If you know the email address is valid, select **Mark valid**. The email is marked as valid and the alert is removed. Continue with composing and sending the email.

- If you don't know the email address is valid and still want to send an email, select **Compose anyway**. The email composer opens. Compose and send the email. 
 
:::image type="content" source="media/lead-email-validation-send-email-notification-message.png" alt-text="Screenshot illustrating the notification message to send email":::

Also, you can send the email by creating a manual email activity through the record's timeline.  


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Enable email validation](enable-email-validation.md)
