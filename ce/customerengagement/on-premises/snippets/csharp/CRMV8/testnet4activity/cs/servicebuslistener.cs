// <snippetservicebuslistener>


using System;
using System.Globalization;
using System.IdentityModel.Tokens;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Xml;

using Microsoft.IdentityModel.SecurityTokenService;
using Microsoft.IdentityModel.Tokens;
using Microsoft.IdentityModel.Tokens.Saml2;
using Microsoft.ServiceBus;

namespace Microsoft.Crm.Sdk.Samples
{
	public sealed class ServiceBusListener
	{
		private string solutionName = "matchpointsolution";
		private string solutionPassword = "jVJ/jQ9i+C5AsPIbTCq77epkXG5d3tj3q9a/fco87NI=";
		private string securityMode = "Transport";
		private string path = "campaignstatsengine";
		private string DefaultIssuer = "owner";

		//Begin - Needed for tokenmode
		private string organizationName = "AdventureWorksCycle";
		private bool isTokenMode = false;
		private string OrganizationClaimType = @"https://schemas.microsoft.com/crm/2011/claims/Organization";

		private string StsPath(string solutionName, bool isServiceBusScope)
		{
			Uri acsUri = ServiceBusEnvironment.CreateAccessControlUri(solutionName);
			if (!isServiceBusScope)
			{
				// remove the -sb from the host name.
				UriBuilder mypath = new UriBuilder(acsUri);
				mypath.Host = acsUri.Host.Replace(string.Format(CultureInfo.InvariantCulture, "{0}-sb", solutionName), solutionName);
				acsUri = mypath.Uri;
			}
			return acsUri.AbsoluteUri;
		}
		//End - Needed for tokenmode 		

		public MessageBufferClient GetMessageBufferClient()
		{
			Assembly assembly = Assembly.GetExecutingAssembly();

			TransportClientEndpointBehavior behavior = new TransportClientEndpointBehavior();

			if (isTokenMode)
			{
				behavior.CredentialType = TransportClientCredentialType.Saml;
				behavior.Credentials.Saml.SamlToken = GetTokenString(organizationName, true);
				behavior.Credentials.SharedSecret.IssuerSecret = solutionPassword;
			}
			else
			{
				behavior.CredentialType = TransportClientCredentialType.SharedSecret;
				behavior.Credentials.SharedSecret.IssuerName = DefaultIssuer;
				behavior.Credentials.SharedSecret.IssuerSecret = solutionPassword;
			}

			#region scheme
			string scheme = Uri.UriSchemeHttp;
			if (securityMode == "Transport")
			{
				scheme = Uri.UriSchemeHttps;
			}
			#endregion
			#region Queue contract.

			Uri queueAddress = ServiceBusEnvironment.CreateServiceUri(scheme, solutionName, path);

			// create a new queue policy with an expiration of 1 hour
			MessageBufferPolicy queuePolicy = new MessageBufferPolicy();
			queuePolicy.ExpiresAfter = TimeSpan.FromHours(1);
			if (securityMode != "Transport") //That is securityMode == None.
			{
				queuePolicy.TransportProtection = TransportProtectionPolicy.None;
			}

			MessageBufferClient messageBufferClient = null;
			for (; ; )
			{
				try
				{
					// get the existing queue or create a new queue if it doesn't exist.			
					messageBufferClient = GetOrCreateQueue(behavior, queueAddress, ref queuePolicy);
				}
				catch
				{
					continue;
				}
				break;
			}
			return messageBufferClient;
			#endregion
		}

		private MessageBufferClient GetOrCreateQueue(TransportClientEndpointBehavior sharedSecredServiceBusCredential, Uri queueUri, ref MessageBufferPolicy queuePolicy)
		{
			MessageBufferClient client;

			try
			{
				client = MessageBufferClient.GetMessageBuffer(sharedSecredServiceBusCredential, queueUri);
				MessageBufferPolicy currentQueuePolicy = client.GetPolicy();
				queuePolicy = currentQueuePolicy;
				// Queue already exists.
				return client;
			}
			//catch (EndpointNotFoundException)
			catch (FaultException)
			{
				// Exception when retrieving the current queue policy.
				// Queue Not found; absorb and make a new queue below. 
				// Other exceptions get bubbled up.
			}
			catch (Exception)
			{
			}
			try
			{
				client = MessageBufferClient.CreateMessageBuffer(sharedSecredServiceBusCredential, queueUri, queuePolicy);
			}
			catch (Exception)
			{
				throw;
			}
			//Created new Queue.			
			return client;
		}

		private string GetTokenString(string organizationName, bool isServiceBusScope)
		{
			// Generate Saml assertions..
			string issuerName = DefaultIssuer;
			//string issuerName = "localhost";

			Saml2NameIdentifier saml2NameIdentifier = new Saml2NameIdentifier(issuerName); // this is the issuer name.
			Saml2Assertion saml2Assertion = new Saml2Assertion(saml2NameIdentifier);

			Uri acsScope = new Uri(StsPath(solutionName, isServiceBusScope));

			saml2Assertion.Conditions = new Saml2Conditions();
			saml2Assertion.Conditions
				.AudienceRestrictions.Add(new Saml2AudienceRestriction(acsScope)); // this is the ACS uri.

			saml2Assertion.Conditions.NotOnOrAfter = DateTime.Now.AddDays(1); // Should this be utc?
			saml2Assertion.Conditions.NotBefore = DateTime.Now.AddHours(-1); // should this be utc?

			string certName = "localhost";

			X509Certificate2 localCert = RetrieveCertificate(certName);
			if (!localCert.HasPrivateKey)
			{
				throw new ArgumentException("Cert should have private key.", "certificate");
			}

			saml2Assertion.SigningCredentials = new X509SigningCredentials(localCert); // this cert should have the private keys.

			// Add claim assertions.			
			saml2Assertion.Statements.Add(
					new Saml2AttributeStatement(
						new Saml2Attribute(OrganizationClaimType, organizationName)));

			// the submitter should always be a bearer.
			saml2Assertion.Subject = new Saml2Subject(new Saml2SubjectConfirmation(Saml2Constants.ConfirmationMethods.Bearer));

			// Wrap it into a security token.
			SecurityTokenHandler tokenHandler = new Saml2SecurityTokenHandler();
			SecurityToken securityToken = new Saml2SecurityToken(saml2Assertion);

			// Serialize the security token.
			StringBuilder sb = new StringBuilder();
			using (XmlWriter writer = XmlTextWriter.Create(new StringWriter(sb, CultureInfo.InvariantCulture)))
			{
				tokenHandler.WriteToken(writer, securityToken);
				writer.Close();
			}

			return sb.ToString();
		}

		public X509Certificate2 RetrieveCertificate(string subjectName)
		{
			X509Store store = null;
			X509Certificate2Collection certificates = null;
			X509Certificate2Collection certificates2 = null;
			try
			{
				store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
				store.Open(OpenFlags.OpenExistingOnly);
				if (store.StoreHandle != IntPtr.Zero)
				{
					certificates2 = store.Certificates;
					certificates = certificates2.Find(X509FindType.FindBySubjectName, subjectName, false);
					if (certificates.Count == 0)
						throw new ArgumentException("Certificate not found: " + subjectName, "subjectName");

					if (certificates.Count > 1)
						throw new ArgumentException("More than one certificate found: " + subjectName, "subjectName");

					if (certificates.Count == 1)
						return new X509Certificate2(certificates[0]);

				}
			}
			finally
			{
				if (certificates != null)
				{
					for (int i = 0; i < certificates.Count; i++)
					{
						certificates[i].Reset();
					}
				}

				if (certificates2 != null)
				{
					for (int j = 0; j < certificates2.Count; j++)
					{
						certificates2[j].Reset();
					}
				}

				if (store != null)
				{
					store.Close();
				}
			}

			return null;
		}
	}
}

// </snippetservicebuslistener>