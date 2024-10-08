/******************************************************************************
 * File: OrdersController.cs
 * Author: KT Navodya (IT21057106)
 * Date: [2024-10-07]
 * Description: This file contains the OrdersController class, which handles
 *              HTTP requests related to order management in the EAD Backend application.
 ******************************************************************************/

import { ref, uploadBytesResumable, getDownloadURL } from "firebase/storage";
import { storage } from "./firebaseConfig";

export const uploadFile = async (file) => {
  try {
    const fileRef = ref(storage, `products/${file.name}`);
    return await uploadBytesResumable(fileRef, file)
      .then(async (res) => {
        const url = await getDownloadURL(res.ref);
        return url;
      })
      .catch((err) => {
        throw Error(`${err}`);
      });
  } catch (error) {
    throw Error(`${error}`);
  }
};
