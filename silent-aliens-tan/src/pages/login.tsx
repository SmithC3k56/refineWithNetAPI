import { Box, Button, Text, VStack } from "@chakra-ui/react";
import { ThemedTitleV2 } from "@refinedev/chakra-ui";
import { useLogin, useTranslate } from "@refinedev/core";

export const Login: React.FC = () => {
  const { mutate: login } = useLogin();

  const t = useTranslate();

  return (
    <Box
      sx={{
        height: "100vh",
        display: "flex",
        flexDirection: "column",
        justifyContent: "center",
        alignItems: "center",
      }}
    >
      <VStack spacing="10" align="stretch">
        <ThemedTitleV2
          collapsed={false}
          wrapperStyles={{
            fontSize: "22px",
          }}
        />

        <Button
          style={{ width: "240px" }}
          colorScheme="blue"
          onClick={() => login({})}
        >
          {t("pages.login.signin", "Sign in")}
        </Button>

        <Text
          justifyContent="center"
          display="inherit"
          fontSize="12px"
          color="gray"
        >
          Powered by
          <img
            style={{ padding: "0 5px" }}
            alt="Keycloak"
            src="https://refine.ams3.cdn.digitaloceanspaces.com/superplate-auth-icons%2Fkeycloak.svg"
          />
          Keycloak
        </Text>
      </VStack>
    </Box>
  );
};
