---
title: Bring your own carrier
description: Use this article to understand how you can bring your own carrier to Dynamics 365 via Azure Direct Routing.
ms.date: 04/07/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template

---

# Bring your own carrier

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Azure Communication Services direct routing enables you to connect your existing telephony infrastructure with Azure so that you can retain your existing carrier and phone numbers, and streamline inter-office call transfers.

## Prerequisites

- Connect to an Azure Communication Services resource to bring in your carrier via direct routing. You must then set up direct routing for the connected Azure resource.
- Be familiar with the following concepts:
  - [Azure Communication Services](/azure/communication-services/overview)
  - [Azure Communication Services direct routing](/azure/communication-services/concepts/telephony/telephony-concept#azure-direct-routing)
- Ensure that the following settings are in place to enable your carrier to work with Azure Communication Services.
  - Check your [direct routing infrastructure requirements](/azure/communication-services/concepts/telephony/direct-routing-infrastructure).
  - [Get a certified Session Border Controller (SBC)](/azure/communication-services/concepts/telephony/certified-session-border-controllers).
  - [Connect the SBC to Azure Communication Services](/azure/communication-services/concepts/telephony/direct-routing-provisioning).
  - Ensure that the SBC responds with a Session Initiation Protocol (SIP) status code in the 100s to the invite request from direct routing. SIP status codes beginning with 4, 5, or 6 indicate failures.
  - Ensure that the phone number of your Dynamics 365 organization is encoded in E.164 format so that the calls can be forwarded by your SBC.
  - Deploy the SBC and DNS server in the same region. Azure Communication Services hosts group calls in the region where the DNS server is deployed. If the SBC and DNS server are in different regions, users can experience a delay. Ensure that your DNS server is not delegated to a sub domain.

## Bring your own phone number via direct routing

1. In the site map of Copilot Service admin center, select **Channels** in **Customer support**. The **Channels** page appears.
    
1. Select **Manage** for **Phone numbers**.

1. Select **Advanced** on the menu.

In the **Bring your own number via Azure Direct Routing** section you can either add one phone number at a time or import multiple phone numbers in bulk.
  ### [Import multiple numbers](#tab/importmultiplenumbers)
  
   1. Select **Import multiple numbers** to upload phone numbers in bulk. The **Import multiple numbers** pane appears.
   1. In **Import multiple numbers** pane, enter the following details.
      - **Carrier**: Indicates the carrier to which the phone number belongs. If the carrier doesn’t exist yet, you can create a new record.
      - **Country/Region**: Select the country or region the phone number belongs to.
      - **Number type**: Select whether toll-free or a local phone number.  
   1. The application displays the PhoneNumber.csv link once you specify the carrier, country/region, and number type. Download the CSV file and fill in the following details for all the phone numbers you want to add in bulk:
      - **msdyn_phonenumber**: Indicates the phone number that you own and have configured in your SBC. The maximum length of the phone number is 15 digits. When the phone number has greater than 10 digits, you must enclose the number in double quotes. For example, "123456789012345". You don't have to append "+" to the phone number. The application automatically appends "+" to the phone number when you upload the CSV file.
      - **msdyn_phoneinboundenabled**: Indicates whether the phone number can receive calls. Set to **True** if you want to receive calls on this number.
      - **msdyn_phoneoutboundenabled**: Indicates whether the phone number can make calls. Set to **True** if you want to make calls on this number.
    > [!NOTE]
     > We recommend that you upload 100 numbers at a time. 
    1. Select **Upload** and upload the CSV file. The application validates the file and displays a success message if the file is valid. If the file is invalid, it displays an error message with details about the errors in the file.
    1. Select Import numbers. Once the import is successful the phone numbers are displayed on the Phone numbers page.
    1. On the **Phone Numbers** page, select **Import status** to view the status of the import. 
  
  ### [Add number](#tab/addnumber)
   1. Select **Add number** to add a single phone number. The **Add your own phone number** dialog appears.
   1. In the **Add your own phone number** dialog, enter the following details.
      - **Phone number**: Indicates the phone number that you own and have configured in your SBC. 
      - **Carrier**: Indicates the carrier to which the phone number belongs. If the carrier doesn’t exist yet, you can create a new record.
      - **Country/Region**: Select the country or region the phone number belongs to.
      - **Number type**: Select whether toll-free or a local phone number.
      - **Calling plans**: Select whether you can make or receive calls on the phone number.
         > [!Note]
         > SMS isn't supported with direct routing.
 ---
1. Select **Add number**.

The new phone number appears in the **Phone numbers** list and is ready for setup. You can now [connect it to a voice workstream](voice-channel-inbound-calling.md), [configure outbound calling](voice-channel-outbound-calling.md#configure-phone-numbers-for-outbound-calling), or even [assign it to a customer service representative](voice-channel-outbound-calling.md#assign-personal-phone-numbers-to-representatives).

## SBC best practices

-	For Microsoft Teams and Azure Communication Services direct routing, you might use the same port number, but you must use a different fully qualified domain name (FQDN).
- To avoid call timeout, ensure that the following settings for Secure Real-time Transport Protocol (SRTP) are configured:
  - Reset SRTP Upon Re-key = Disable
  - Generate SRTP Keys = Only if Required
- Make sure that you have sufficient transcoding licenses if your service provider and Azure Communication Services don't support the same codec.
- If your direct routing SBC is behind a firewall, make sure that the SIP Application Layer Gateway is disabled. Also, make sure that the media endpoint communicating with Azure Communication Services is using a public IP address, not a private one.
- Make sure that your SBC is using a DNS server located within the same region where Dynamics 365 is hosted to avoid latency issues.
  
### Related information

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](voice-channel-inbound-calling.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Integrate a third-party IVR system with voice channel](voice-channel-contextual-transfer-external-ivr.md)  
[Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
