<table>
<colgroup>
<col style="width: 66%" />
<col style="width: 33%" />
</colgroup>
<thead>
<tr>
<th style="text-align: left;">Sentiment analysis for emails</th>
<th>Public Preview,<br />
October, 2025</th>
</tr>
</thead>
<tbody>
</tbody>
</table>

# Contents

[Introduction [2](#introduction)](#introduction)

[Prerequisites [2](#prerequisites)](#prerequisites)

[Administrator experience
[2](#administrator-experience)](#administrator-experience)

[Customer service representative experience
[3](#customer-service-representative-experience)](#customer-service-representative-experience)

[Preview disclaimer [4](#preview-disclaimer)](#preview-disclaimer)

[Copyright [4](#copyright)](#copyright)

# Introduction

Sentiment analysis enables agents and supervisors to understand
real-time and historical customer sentiment across channels to improve
customer service. The application uses natural language processing (NLP)
and machine learning (ML) algorithms to understand customer sentiments.

The application displays the sentiment intensity indicators are based on
the emails received by the customer. Sentiment intensity is scored in
one of seven gradients: three positive, three negative, and one neutral.

Sentiment analysis supports multiple languages. Using Microsoft Azure
Text Translator API, conversations in more than 40 languages now receive
sentiment scores.

**Note**:

- Non-English conversations are translated to English, then scored.

- Unsupported languages don't receive a sentiment score.

- If profanity is detected in English, the sentiment shows as Negative
  or Very negative.

# Prerequisites

- You have the CSR Manager and System Administrator role to enable the
  feature.

- You have the Customer Service representative role.

# Administrator experience

1.  In Power Apps, perform the steps in [Add an existing setting
    definition](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/create-edit-configure-settings#adding-an-existing-setting-definition)
    to add the **Enable Email Sentiment** setting definition.

2.  Set the value of the override value in **Setting environment value**
    to **Yes**.

3.  Publish your changes.

4.  In the Customer Service admin center or Contact Center admin center
    app, perform the following steps:

<!-- -->

1.  In the site map, navigate to **Copilot for questions and emails** in
    one of the following ways:

2.  **Agent experience** \> **Productivity**

3.  **Operations** \> **Insights**

4.  Select **Manage**.

5.  Select the **Let agents view email sentiments** check box in **Email
    Sentiments**.

6.  Select **Save**.

7.  Go to **Agent experience** \> **Workspaces.**

8.  In **Workspaces**, select **Manage** for **Agent experience
    profiles**.

9.  Select **Customer Service workspace+inbox-default profile**.

10. Select **Edit** on the **Inbox** section.

11. On the **Inbox settings** dialog, do the following:

    1.  Select **Inbox record types** and then select **Email**.

    2.  Select the ellipsis to add the **Sentiment** field and
        **Sentiment** icon. Learn more in [Custom card
        configuration](https://learn.microsoft.com/en-us/dynamics365/customer-service/administer/configure-inbox#custom-card-configuration).

# Customer service representative experience

After the administrator enables the sentiment analysis for emails,
customer service representatives can do the following actions when using
sentiment analysis for emails:

- When customer service representatives get an incoming email from a
  customer, the Customer sentiment card is displayed on the email form.
  The customer sentiment card displays the following:

  - **Current sentiment**: The customer’s current sentiment. A sentiment
    intensity indicator in the corresponding colors is also displayed.

  - **Sentiment timeline**: A visual representation that shows how the
    customer sentiment in the emails received changes across a period.
    The timeline displays indicators for up to six customer emails,
    including the current email. Customer service representatives can
    select historical sentiment and then select **View email**. The
    system shows the relevant email for that period and sentiment in a
    new tab.

- The inbox view displays the sentiment with the sentiment intensity
  indicator.

> **Note**: For emails received before the feature is enabled, the
> system doesn’t display the sentiment.

# Preview disclaimer

Preview features are features that aren’t complete but are made
available on a “preview” basis so customers can get early access and
provide feedback. Preview features are not supported by Microsoft
Support, may have limited or restricted functionality, aren’t meant for
production use, and may be available only in selected geographic areas.

# Copyright

This document is provided "as-is". Information and views expressed in
this document, including URL and other Internet web site references, may
change without notice.

Some examples depicted herein are provided for illustration only and are
fictitious. No real association or connection is intended or should be
inferred.

This document does not provide you with any legal rights to any
intellectual property in any Microsoft product. You may copy and use
this document for your internal, reference purposes. This document is
confidential and proprietary to Microsoft. It is disclosed and can be
used only pursuant to a non-disclosure agreement.

© 2024 Microsoft. All rights reserved.

Microsoft is trademark of the Microsoft group of companies. All other
trademarks are property of their respective owners.
