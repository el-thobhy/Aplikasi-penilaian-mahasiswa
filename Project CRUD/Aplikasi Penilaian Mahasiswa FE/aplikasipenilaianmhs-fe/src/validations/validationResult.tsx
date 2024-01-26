import { ErrorProperty } from "./errorProperty";
import { ValidationBase } from "./validationBase";

export const ValidationResult = {
  Validate: (list: ErrorProperty[]) => {
    let cls: any;
    list.forEach((e: ErrorProperty) => {
      cls = {
        ...cls,
        [e.propertyName]: new ValidationBase(false, e.errorMessage),
      };
    });
    return cls;
  },
};
