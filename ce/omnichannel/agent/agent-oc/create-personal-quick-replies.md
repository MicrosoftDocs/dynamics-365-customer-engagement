---
title: Create personal quick replies in Omnichannel for Customer Service | MicrosoftDocs
description: Create personal quick replies in Omnichannel for Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/03/2020
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
search.audienceType: 
  - admin
  - customizer
  - end user
search.app: 
  - D365CE
  - D365CS
---

# Preview: Create personal quick replies

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

## Introduction

You can use the personalization menu that's accessible through the application tab to add *personal quick replies*, also called *predefined messages*. You can create quick replies for the common questions and scenarios that you need to address in your role. You can tag the replies with keywords that help you invoke the quick replies when you're interacting with customers.

## Create personal quick replies

You can create, edit, and delete the personal quick replies you own. The quick replies that you create are available on the **Personal** tab in the **Quick replies** panel of the conversation window.

1. Sign in to Omnichannel for Customer Service, and on the home page, select the plus sign ![plus sign](../../media/oceh/plus-sign.png) on the application tab.
   > ![Personalization menu](../../media/oceh/personalization-menu.png "Personalization menu")

2. Select **Personalization**. The **Personalization User settings** page appears.<!--You don't need to describe what appears.-->

3. On the **Personal quick replies** tab, select **New Personal quick reply**, and do the following:
    - **Message:** Enter the text you want to use for your reply.<!--Suggested.-->
    - **Locale:** Select the language in which you want to create the quick reply.

        > [!NOTE]
        > Personal quick replies aren't localized in Omnichannel for Customer Service. To provide quick responses in multiple languages, create a separate quick response record for each language and select its corresponding locale.

   > ![Create a personal quick reply](../../media/oceh/create-personal-quick-reply.png "Create a personal quick reply")
4. In the **Tags** area, enter the keyword you want to associate with the quick reply, and then select ![plus sign](../../media/oceh/plus-sign.png). If you want to use the number sign (#), don't use it anywhere else in the keyword except at the beginning.
5. Select **Save**.

## Use personal quick replies

The quick replies you created are available on the **Personal** tab, and those created by the administrator are available on the **All** tab. Use the personal quick replies when you're in a conversation with a customer by doing the following:

1. Select the quick responses icon ![quick responses icon](../../media/oceh/personal-quick-reply-icon.png)<!--What do you think?--> at the bottom of your conversation window. The **Quick replies** panel displays the available predefined messages on the **All** and **Personal** tabs.
2. Select the **Personal** tab, and type the number sign (**#**) in the compose box to list the tags and search for the personal quick replies that are available for your use.
3. Use the **more** option to view the complete text of the quick reply.

> ![Use personal quick reply](../../media/oceh/use-personal-quick-replies.png "Use personal quick reply")

### See also

[Send predefined messages in chats](oc-conversation-control.md#send-predefined-messages-in-chats)  
[Manage applications](oc-manage-applications.md)  