import { Button } from "@chakra-ui/button";
import { Box, useDisclosure } from "@chakra-ui/react";
import React from "react";
import { useTranslation } from "react-i18next";
import { BookModal } from "../BookModal";

export const BookControls = () => {
  const { t } = useTranslation();
  const { isOpen, onOpen, onClose } = useDisclosure();

  const handleAddBookClick = onOpen;

  return (
    <Box marginTop={4} marginBottom={4}>
      <Button onClick={handleAddBookClick}>{t("AddBook")}</Button>
      <BookModal isOpen={isOpen} onClose={onClose} />
    </Box>
  );
};
