---
title: BIMI support
description: BIMI support in Dynamics 365 Marketing.
ms.date: 05/01/2023
ms.custom: 
  - dyn365-marketing
ms.topic: reference
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# BIMI support

Microsoft Dynamics 365 is a powerful platform for managing customer relationships and marketing campaigns. Email is one of the most crucial components of marketing, and making sure that your emails reach their recipients and stand out in their inboxes is essential to effective email marketing. This is where Brand Indicators for Message Identification (BIMI) comes in. BIMI allows you to display your brand logo next to your email messages in the recipient’s inbox, improving the effectiveness of your email marketing campaigns. 

BIMI is a new standard for email security and brand verification and is currently only supported by a few email providers (Google, Fastmail, Yahoo, etc.). You can set up BIMI using a DNS record that points to a logo image file hosted on the organization's website. To prevent email fraud and ensure that only authorized senders can send email messages from your domain, BIMI requires that the sender's email domain be validated using email authentication protocols like *SPF*, *DKIM*, and *DMARC*.

In this article, we explore the benefits of using BIMI and its integration with Dynamics 365 Marketing.
BIMI is useful for organizations and businesses to adopt for several reasons:
- **Increased brand recognition**: BIMI allows organizations to display their logo next to their email messages in the inbox. This can help increase brand recognition and make it easier for recipients to identify legitimate messages from the sender.
- **Improved email deliverability**: BIMI requires that the sender's email domain is properly authenticated using email authentication protocols like SPF, DKIM, and DMARC. By setting up these protocols correctly, you can improve your email deliverability and ensure that your email messages are more likely to land in the recipient's inbox.
- **Better engagement**: By displaying a recognizable logo next to their messages, senders can increase the likelihood that recipients engage with their emails. This can lead to higher open rates, click-through rates, and overall engagement.
- **Enhanced security**: BIMI helps improve the security of the email ecosystem by encouraging the adoption of DMARC, which provides a way to authenticate email messages and prevent email fraud.
- **Future proofing**: BIMI is a relatively new technology, but it's expected to become more widely adopted over time. By implementing BIMI now, email senders can future-proof their email marketing campaigns and ensure that they're prepared for the evolving email landscape.

Microsoft, on the other side, has its approach known as "**brand cards**," which does much the same thing as BIMI without utilizing DNS. Businesses can instead get started by signing up for the [Microsoft Business Profile](https://www.microsoft.com/bing/bing-pages-overview?FORM=&rtc=1) program. Office Web Apps (OWA) in Office 365 and Outlook.com use the verified icon that businesses provide to Microsoft when they join up. Some brand cards are created for well-known companies because the application uses Bing.

> [!div class="mx-imgBorder"]
> ![brand cards](media/brand-cards.png "brand cards")

## How to set-up BIMI

1. **Authenticate your organization’s emails**:
- **Set up SPF**: Sender Policy Framework (SPF) is an email authentication protocol that helps to prevent email spoofing by verifying that the sending IP address is authorized to send emails on behalf of your domain. To set up SPF, you need to create an SPF record in your DNS zone file that lists the IP addresses that are authorized to send emails on behalf of your domain. Learn more: Set-up SPF
- **Set up DKIM**: DomainKeys Identified Mail (DKIM) is an email authentication protocol that helps to prevent email spoofing by verifying that the email was sent by an authorized sender and that the email content hasn't been tampered with. To set up DKIM, you need to generate a DKIM key pair and add a DKIM record to your DNS zone file. You also need to set up DKIM for your sending domain.
- **Verify your email authentication using DMARC**:
    - DMARC is a protocol that helps prevent email spoofing and phishing attacks. Email-domain authentication's major goal is to find fraudulent emails and domains and stop spam, phishing, and other malicious conduct.
    - A method called **DomainKeys Identified Mail (DKIM)** helps make these authentications possible. Domain authentication is implemented through the internet DNS system and is based on public/private key encryption and signatures. 
> [!IMPORTANT]
> If your organization uses **Domain-based Message Authentication, Reporting, and Conformance** ([DMARC](https://dmarc.org/wiki/FAQ)) to protect against phishing attacks involving your domain, then it's important to set up DKIM for your sending domains. This will help to prevent false positives during DMARC checks made by receiving systems.

2. **Create a BIMI-compliant logo image**: To display your brand logo in email clients that support BIMI, you need to create a logo image that meets the BIMI specifications. BIMI requires that the logo image is a SVG file and that the image file is hosted on a secure server (HTTPS). Additionally, the SVG file must be publicly accessible and located at a specific URL. The SVG file size should be less than 32 kilobytes. **Learn more**: [Creating BIMI SVG Logo Files - BIMI Group](https://bimigroup.org/creating-bimi-svg-logo-files/)
3. **Publish a BIMI record in DNS**: To set up BIMI, you need to publish a BIMI record in DNS. This involves adding a TXT record to your DNS zone file, which specifies the location of your brand logo image file and its dimensions. The format of the TXT record should be as follows:

    `default._bimi.<your-domain> IN TXT "v=BIMI1; l=https://<url-to-your-brand-logo>; a=<PEM URL>;"`

    In most cases, you'll replace `<your-domain>` with your actual domain name and `<url-to-your-brand-logo>` with the URL to your brand logo SVG file. `<PEM URL>` is an optional field that points to where your Verified Mark Certificate (VMC) is hosted.

    Putting it all together, you enter your BIMI record in two parts. The first part (the name) looks like this:

    `default._bimi.contoso.com`

    The text record (the TXT value) looks like this:

   `v=BIMI1; l=https://contoso.com/logo.svg`

    Alternatively, you can use the [BIMI record generator](https://bimigroup.org/bimi-generator/) to format all the information for you. You'll need to enter your domain, SVG image, and optional VMC file.

4. **Validate your BIMI record**: Use the [BIMI Validator tool](https://bimigroup.org/bimi-generator/) to ensure that your BIMI record is correctly formatted and that your brand logo image file is accessible from the specified URL.

BIMI support is currently limited, so not all email clients or providers display the BIMI logo. However, by using BIMI with Microsoft Dynamics 365 Marketing, organizations can enhance the effectiveness of their email marketing campaigns and strengthen their brand's reputation.

[!INCLUDE[footer-include](../includes/footer-banner.md)]