import { createUserManager } from "redux-oidc";
import { UserManagerSettings } from "oidc-client";

export const RegisterUrl = "http://localhost:5000/account/register";

const userManagerConfig: UserManagerSettings = {
  client_id: "spa",
  redirect_uri: "http://localhost:5100/callback",
  response_type: "token id_token",
  scope: "openid profile api1",
  authority: "http://localhost:5000",
  silent_redirect_uri: "http://localhost:5100/silent_renew.html",
  automaticSilentRenew: true,
  filterProtocolClaims: true,
  loadUserInfo: true,
  monitorSession: true
};

const userManager = createUserManager(userManagerConfig);

export default userManager;
