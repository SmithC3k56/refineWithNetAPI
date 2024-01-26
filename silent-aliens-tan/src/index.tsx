import React from "react";
import { createRoot } from "react-dom/client";

import { ReactKeycloakProvider } from "@react-keycloak/web";
import Keycloak from "keycloak-js";

import App from "./App";
import "./i18n";

const keycloak = new Keycloak({
  clientId: "refine",
  url: "yourdomain.com/auth",
  realm: "TestLogin",
});

const container = document.getElementById("root") as HTMLElement;
const root = createRoot(container);

root.render(
  <React.Suspense fallback="loading">
    <ReactKeycloakProvider authClient={keycloak}>
      <App />
    </ReactKeycloakProvider>
  </React.Suspense>
);
