---
title: Create personal quick replies in Omnichannel for Customer Service | MicrosoftDocs
description: Create personal quick replies in Omnichannel for Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 01/11/2021
ms.topic: article
ms.service: dynamics-365-customerservice
search.audienceType: 
  - admin
  - customizer
  - end user
search.app: 
  - D365CE
  - D365CS
---

# Create personal quick replies

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

You can use the personalization menu that's accessible through the application tab to add *personal quick replies*, also called *predefined messages*. You can create quick replies for the common questions and scenarios that you need to address in your role. You can tag the replies with keywords that help you invoke the quick replies when you're interacting with customers.

## Create personal quick replies

You can create, edit, and delete the personal quick replies you own. The quick replies that you create are available on the **Personal** tab in the **Quick replies** panel of the conversation window.

1. Sign in to Omnichannel for Customer Service, and on the home page, select the plus sign ![plus sign](media/plus-sign.png) on the application tab.
   > ![Personalization menu](media/personalization-menu.png "Personalization menu")

2. Select **Personalization**.

3. On the **Personal quick replies** tab, select **New Personal quick reply**, and do the following:
    - **Message:** Enter the text you want to use for your reply.
    - **Locale:** Select the language in which you want to create the quick reply.

        > [!NOTE]
        > - To avoid duplicating quick replies, check the predefined messages before creating a personal quick reply.
        > - Personal quick replies aren't localized in Omnichannel for Customer Service. To provide quick responses in multiple languages, create a separate quick response record for each language and select its corresponding locale.

   > ![Create a personal quick reply](media/create-personal-quick-reply.png "Create a personal quick reply")
4. In the **Tags** area, enter the keyword you want to associate with the quick reply, and then select ![plus sign](media/plus-sign.png). If you want to use the number sign (#), don't use it anywhere else in the keyword except at the beginning.
5. Select **Save**.

It can take up to 15 minutes for the quick replies to be available for your use.

For more information on personal quick replies, see [Send predefined messages in chats](oc-conversation-control.md#send-predefined-messages-in-chats).

### See also

[Send predefined messages in chats](oc-conversation-control.md#send-predefined-messages-in-chats)  
[Manage applications](oc-manage-applications.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]