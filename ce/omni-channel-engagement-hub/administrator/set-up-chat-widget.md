---
title: "Set up a chat widget"
description: "Instructions to configure a chat widget in Omni-channel Engagement Hub."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 12/15/2018
ms.service: 
ms.topic: article
ms.assetid: 983e691f-0ee2-4e30-ba70-7e534c762611
ms.custom: 
---
# Set up a chat widget

As an admin, you can set up a chat widget for your website to engage with your customers.

## Add a chat widget

1. Sign in to Omni-channel Engagement Hub.
2. Go to **Administration** &gt; **Work Streams**.
3. Select **New** to create a work stream.
4. On the **Summary** tab, in the **Stream Source** field, select **Live Chat**.
5. Specify values under **Agents**, **Agent Profiles**, and **Context Variable**. For more information, see [Create and manage work streams](work-streams.md).
6. On the **Chat settings** tab, in the **Chat widgets** section, select **Add**.
7. On the **New Chat Widget** page, provide the appropriate information on each tab:

    - **Basic details**:

        1. In the **General information** section, enter a name for the chat widget. You can optionally specify authentication settings. Save the record to enter more details. For more information about how to specify authentication settings, see the [Set up authentication settings](#set-up-authentication-settings) section later in this topic.
        2. In the **Widget location** section, select **Add** to specify the website domain where the chat widget must be shown. If you don't specify a domain, the chat widget is shown in all configured domains. The domain format should not include the protocol (for example, **http** or **https**).
        3. Copy the value in the **Code snippet** section, and embed it in the HTML source of your website.

        ![Configure the basic details of a chat widget](../media/oc-chat-widget-basic-details-tab.png "Configure the basic details of a chat widget")

    - **Design**: Use this tab to specify the theme color, logo, title, subtitle, position, and operating hours of the chat widget. For more information about how to set up operating hours, see the [Set up operating hours](#set-up-operating-hours) section later in this topic.

        ![Configure the design of a chat widget](../media/oc-chat-widget-design-tab.png "Configure the design of a chat widget")

    - **Survey**: Use this tab to set up a pre-chat survey. This survey is shown to users before a conversation is initiated. For more information, see the [Set up a pre-chat survey](#set-up-a-pre-chat-survey) section later in this topic.

        ![Configure a pre-chat survey in a chat widget](../media/oc-chat-widget-survey-tab.png "Configure a pre-chat survey in a chat widget")

## Set up a pre-chat survey

You can configure your chat engagement to show users a survey that they should respond to before they start the conversation.

1. Sign in to Omni-channel Engagement Hub.
2. Go to **Administration** &gt; **Work Streams**.
3. Select the work stream where you created your chat widget.
4. On the **Chat settings** tab, select the name of the chat widget.
5. On the **Survey** tab, in the **Pre-chat survey** field, select **Yes**.
7. Select **Add question** to add questions from the question library. For more information, see the [Set up a question library](#set-up-a-question-library) section later in this topic.

    > [!NOTE]
    > You can add only five questions to a pre-chat survey.

8. In the **Quick Create: Survey Question Sequence** pane, select a question from the question library, and specify whether it's required or optional.

    > [!NOTE]
    > In this preview, validations aren't supported in pre-chat surveys.

    ![Add a question to the pre-chat survey](../media/oc-add-chat-question.png "Add a question to the pre-chat survey")

9. Select **Save**.

    The questions are added to the pre-chat survey.

    ![Configure a pre-chat survey in a chat widget](../media/oc-chat-widget-survey-tab.png "Configure a pre-chat survey in a chat widget")

10. To change the order of a question, select it, and then select **Move up** or **Move down**.

    ![Change the order of a question in a pre-chat survey](../media/oc-change-question-order.png "Change the order of a question in a pre-chat survey")

## Set up a question library

You can add questions to the question library in a work stream. You can then use those questions to create pre-chat surveys for chat widgets that are created in that work stream.

1. Sign in to Omni-channel Engagement Hub.
2. Go to **Administration** &gt; **Work Streams**.
3. Select the work stream to create a question library in.
4. On the **Survey questions library** tab, select **Add question**.

    ![Add a question to the question library](../media/oc-add-question.png "Add a question to the question library")

5. On the **New Survey Question** page, provide the following information:

    - **Question name**: Enter a name for the question. The name must be unique within a work stream.
    - **Answer type**: Select the type of answer that is required from users:

        - **Single line**: The user can enter a single line of text.
        - **Multiple lines**: The user can enter multiple lines of text.
        - **Option set**: The user can select an option in a drop-down list. If you select this answer type, you must save the question before you can specify the answer options.

        ![Question where the answer type is Option set](../media/oc-option-set-answer-type.png "Question where the answer type is Option set")

    - **Question text**: Enter the text of the question.
    - **Help text**: Enter help text that will be shown to the user as a watermark.

    ![Add Help text to a question](../media/oc-question-help-text.png "Add Help text to a question")

6. Select **Save**.

## Set up quick replies

Quick replies are pre-defined messages that can be created for agents to quickly reply to common questions by customers. For information on agent experience of quick response, see [Send quick replies in the chat](../agent/agent-usd/left-control-panel.md#send-quick-replies-in-the-chat).  

1. Sign in to Omni-channel Engagement Hub.
2. Go to **Administration** &gt; **Quick Responses**.
3. Select **New** to add a quick reply. To edit an existing quick reply, select the name of the quick reply.
4. Provide or change the following information:

    - **Title**: Enter the title of the message.
    - **Locale**: Specify the locale of the message.

        > [!NOTE]
        > In this preview, the **Locale** field can't be edited.

    - **Message**: Enter the text of the message.

        > [!NOTE]
        > This field supports slugs, but the slug editor isn't available in this preview.

    ![Create a quick reply](../media/oc-create-a-quick-reply.png "Create a quick reply")

6. Select **Save**.

## Set up operating hours

Operating hours define the hours when your organization's customer support team is active and available to serve customers. By setting up operating hours, you help your customers and your organization work together to resolve issues. After you create an operating hour record, you must add it to the **Design** tab of the appropriate chat widget to make it work.

> [!NOTE]
> The chat widget will be shown only during the defined operating hours. At all other times, it will be hidden.

1. Sign in to Omni-channel Engagement Hub.
2. Go to **Administration** \> **Operating Hours**.
3. Select **New** to add an operating hour record.
4. In the **Quick Create: Operating Hour** pane, provide the following information:

    - **Name**: Enter a name for the operating hour record.
    - **24/7**: Select **Yes** if the chat widget should be available 24/7. Select **No** if the chat widget should be available only on specific days of the week. By default, **No** is selected. 
    - **Start time (HH:mm)**: Specify the start time of the operating hours, in 24-hour format.
    - **End time (HH:mm)**: Specify the end time of the operating hours, in 24-hour format.

        > [!NOTE]
        > The end time should not be earlier than the start time. In addition, it should not be less than five minutes after the start time.

    - **Work days**: Specify the days of the week when customer support is available.
    - **Time zone**: Specify the time zone of the operating hours.
    - **Description**: Enter an optional description of the operating hour record.

    ![Create an operating hour record](../media/oc-quick-create-operating-hour.png "Create an operating hour record")

5. Select **Save and close**.

## Set up authentication settings

You can create authentication settings to validate a signed-in customer from a domain, and to extract information based on the context variables that are defined. You can differentiate your anonymous customers from authenticated customers, and you can create rules based on the context variables. For example, you can have separate queues for anonymous customers and authenticated customers. Because you have more information about your authenticated customers, you can also prioritize them based on specific variables, such as shopping cart value or a privileged status.

After you create an authentication settings record, you must add it in the **Basic details** tab of the appropriate chat widget to make it work.

1. Sign in to Omni-channel Engagement Hub.
2. Go to **Administration** \> **Chat Authentication**.

    A list of existing authentication settings is shown.

3. Select **New** to add an authentication settings record.
4. On the **New Authentication Settings** page, provide the following information:

    - **Name**: Enter a name for the authentication setting.
    - **Public key URL**: Specify the public key URL of the domain. This URL is used to validate the information that comes in from the JavaScript Object Notation (JSON) Web Token (JWT) of the domain that a customer has signed in to.
    - **JavaScript client function**: Specify the JavaScript client function to use for authentication. This function extracts a token from the token endpoint.

    For more information about how to find the public key URL and JavaScript client function, see the [Setup for a Microsoft Dynamics 365 portal](#setup-for-a-dynamics-365-portal) section or the [Setup for portals that don't use Dynamics 365 (custom portal)](#setup-for-portals-that-dont-use-dynamics-365-custom-portal) section later in this topic.

5. Select **Save**.

When a signed-in customer on a portal opens the chat widget, the JavaScript client function passes the JWT from the client to the server. The JWT is decrypted and validated by using the public key, and the information is then passed to the chat agent in Omni-channel Engagement Hub. As an admin, you can also pass additional information about the signed-in customer in the JWT by defining custom context variables. The context variables must be defined exactly as they are defined in Common Data Service for Apps.

### Setup for a Dynamics 365 portal

If you're adding authentication for a chat widget on a Microsoft Dynamics 365 portal, the public key URL, JavaScript client function, and JWT are available out of the box. Here is how you can get the required values:

- **Public key URL**: `<portal_base_URL>/_services/auth/publickey`
- **JavaScript client function**: `auth.getAuthenticationToken`
- **Token endpoint**: `<portal_base_URL>/_services/auth/token`

### Setup for portals that don't use Dynamics 365 (custom portal)

If you're adding authentication for a chat widget on a portal that doesn't use Dynamics 365 (that is, on a custom portal), follow these steps to set up the environment.

1. Define the private/public key pairs on your server. These keys are used to sign and encrypt the JWT that is sent to the server. Only RSA256 keys are supported.

    Here is sample code for generating private/public key pairs.

    ```
    openssl genpkey -algorithm RSA -out private_key.pem -pkeyopt rsa_keygen_bits:2048
    openssl rsa -pubout -in private_key.pem -out public_key.pem
    ```

2. Expose the public key endpoint as a URL that contains the public key as a string.
3. Create a client-side JavaScript function that returns the signed JWT and the public key.

    Here is sample code for defining the JavaScript client function.

    ```
    window["getAuthenticationToken"] = function(callback){
        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {
                callback(xhttp.responseText);
            }
        };
        xhttp.onerror = function(error) {
            callback(null);
        };
        xhttp.open("GET", "https://contosohelp.com/token", true);
        xhttp.send();
    }
    ```

4. After authentication, you must identify your customer from among Dynamics 365 contacts. You must extract the globally unique identifier (GUID) that Dynamics 365 uses for the contact. Here is an example of a GUID: `87b4d06c-abc2-e811-a9b0-000d3a10e09e`.
5. Create a JSON payload that includes `sub` (the GUID) and three attributes (`iss`, `iat`, `exp`) as mandatory claims.

    Here is a sample JSON payload.

    ```
    {
        "sub" : "87b4d06c-abc2-e811-a9b0-000d3a10e09e",
        "preferred_username" : "a184fade-d7d0-40e5-9c33-97478491d352",
        "phone_number" : "1234567",
        "given_name" : "Bert",
        "family_name" : "Hair",
        "email" : "admin@contosohelp.com",
        "lwicontexts" :"{\"msdyn_cartvalue\":\"10000\", \"msdyn_isvip\":\"false\"}",
        "iat" : 1542622071,
        "iss" : "contosohelp.com",
        "exp" : 1542625672,
        "nbf" : 1542622072
    }
    ```

6. Add custom context variables, if they are required. The context variables must be defined exactly as they are defined in Common Data Service for Apps.

    Here is a sample definition of custom context variables.

    ```
    def create_token(user_json):
        with open('private_key.pem', 'r') as myfile:
            data = myfile.read()
        json_token = json.loads(user_json)
        lwicontexts = {}
        lwicontexts['msdyn_cartvalue'] = 10000
        lwicontexts['msdyn_isvip'] = "false"
        json_token['lwicontexts'] = json.dumps(lwicontexts)
        encoded_jwt = jwt.encode(json_token, data, algorithm='RS256')
        return encoded_jwt
    ```

    > [!NOTE]
    > - The `user_json` parameter comes from the identity provider (for example, Microsoft Azure Active Directory or Google).
    > - `lwicontexts` is the key whose value should have the custom context variable serialized as string. It must be specified in lowercase letters.

7. Sign and encrypt this payload by using the private key to generate the JWT. 

    Here is sample code for encrypting the payload. (This code is included in the previous sample code for defining custom context variables.)

    ```
    encoded_jwt = jwt.encode(json_token, data, algorithm='RS256')
    return encoded_jwt
    ```
