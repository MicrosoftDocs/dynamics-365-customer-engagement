// <snippetcrudoperations3>


 catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> e) { HandleException(e); }
 catch (TimeoutException e) { HandleException(e); }
 catch (SecurityTokenValidationException e) { HandleException(e); }
 catch (ExpiredSecurityTokenException e) { HandleException(e); }
 catch (MessageSecurityException e) { HandleException(e); }
 catch (SecurityNegotiationException e) { HandleException(e); }
 catch (SecurityAccessDeniedException e) { HandleException(e); }
 catch (Exception e) { HandleException(e); }

// </snippetcrudoperations3>