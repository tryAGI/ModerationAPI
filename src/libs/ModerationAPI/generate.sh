dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://docs.moderationapi.com/openapi.json
autosdk generate openapi.yaml \
  --namespace ModerationAPI \
  --clientClassName ModerationAPIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

# AutoSDK currently emits an all-arguments constructor for NewModerateModerateRequest
# whose policies parameter is long enough to trip CS7013 on .NET 10. Keep the
# parameterless constructor and object-initializer path, which is what this SDK uses.
python3 - <<'PY'
from pathlib import Path

path = Path("Generated/ModerationAPI.Models.NewModerateModerateRequest.g.cs")
text = path.read_text(encoding="utf-8")

signature = "\n        public NewModerateModerateRequest("
signature_index = text.find(signature)
if signature_index < 0:
    raise SystemExit("Failed to apply NewModerateModerateRequest constructor workaround.")

start_marker = '\n        /// <summary>\n        /// Initializes a new instance of the <see cref="NewModerateModerateRequest" /> class.\n        /// </summary>'
start_index = text.rfind(start_marker, 0, signature_index)
if start_index < 0:
    raise SystemExit("Failed to locate constructor documentation block for workaround.")

brace_index = text.find("{", signature_index)
if brace_index < 0:
    raise SystemExit("Failed to locate constructor body for workaround.")

depth = 0
end_index = -1
for i in range(brace_index, len(text)):
    if text[i] == "{":
        depth += 1
    elif text[i] == "}":
        depth -= 1
        if depth == 0:
            end_index = i
            break

if end_index < 0:
    raise SystemExit("Failed to find constructor end for workaround.")

updated = text[:start_index] + "\n" + text[end_index + 1 :]
path.write_text(updated, encoding="utf-8")
PY

python3 - <<'PY'
from pathlib import Path

targets = [
    Path("Generated/ModerationAPI.IModerationAPIClient.NewModerateModerate.g.cs"),
    Path("Generated/ModerationAPI.ModerationAPIClient.NewModerateModerate.g.cs"),
]

for path in targets:
    text = path.read_text(encoding="utf-8")

    signature = "NewModerateModerateAsync(\n            global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestContentText"
    signature_index = text.find(signature)
    if signature_index < 0:
        raise SystemExit(f"Failed to locate overload signature in {path.name}.")

    start_index = text.rfind("\n        /// <summary>", 0, signature_index)
    if start_index < 0:
        raise SystemExit(f"Failed to locate overload documentation block in {path.name}.")

    if path.name.startswith("ModerationAPI.I"):
        end_index = text.find(");", signature_index)
        if end_index < 0:
            raise SystemExit(f"Failed to locate overload terminator in {path.name}.")
        updated = text[:start_index] + "\n" + text[end_index + 2 :]
    else:
        brace_index = text.find("{", signature_index)
        if brace_index < 0:
            raise SystemExit(f"Failed to locate overload body in {path.name}.")

        depth = 0
        end_index = -1
        for i in range(brace_index, len(text)):
            if text[i] == "{":
                depth += 1
            elif text[i] == "}":
                depth -= 1
                if depth == 0:
                    end_index = i
                    break

        if end_index < 0:
            raise SystemExit(f"Failed to locate overload end in {path.name}.")

        updated = text[:start_index] + "\n" + text[end_index + 1 :]

    path.write_text(updated, encoding="utf-8")
PY

python3 - <<'PY'
from pathlib import Path

path = Path("Generated/ModerationAPI.JsonSerializerContext.g.cs")
text = path.read_text(encoding="utf-8")
replacements = {
    '[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>))]':
    '[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>), TypeInfoPropertyName = "ModeratePoliciesIList")]',
    '[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>), TypeInfoPropertyName = "OneOfNewModerateModerateRequestPolicieToxicityNewModerateModerateRequestPoliciePersonalInformationNewModerateModerateRequestPolicieToxicitySevereNewModerateModerateRequestPolicieHateNewModerateModerateRequestPolicieIllicitNewModerateModerateRequestPolicieIllicitDrugsNewModerateModerateRequestPolicieIllicitAlcoholNewModerateModerateRequestPolicieIllicitFirearmsNewModerateModerateRequestPolicieIllicitTobaccoNewModerateModerateRequestPolicieIllicitGamblingNewModerateModerateRequestPolicieCannabisNewModerateModerateRequestPolicieAdultNewModerateModerateRequestPolicieCryptoNewModerateModerateRequestPolicieSexualNewModerateModerateRequestPolicieFlirtationNewModerateModerateRequestPolicieProfanityNewModerateModerateRequestPolicieViolenceNewModerateModerateRequestPolicieSelfHarmNewModerateModerateRequestPolicieSpamNewModerateModerateRequestPolicieSelfPromotionNewModerateModerateRequestPoliciePoliticalNewModerateModerateRequestPolicieReligionNewModerateModerateRequestPolicieCodeAbuseNewModerateModerateRequestPoliciePiiMaskingNewModerateModerateRequestPolicieUrlMaskingNewModerateModerateRequestPolicieGuideline2")]':
    '[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>), TypeInfoPropertyName = "ModeratePoliciesOneOf")]\n    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Nullable<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>), TypeInfoPropertyName = "NullableModeratePoliciesOneOf")]',
    '[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<string, object, global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>>))]':
    '[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<string, object, global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>>), TypeInfoPropertyName = "ModifiedContentAnyOf")]\n    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Nullable<global::ModerationAPI.AnyOf<string, object, global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>>>), TypeInfoPropertyName = "NullableModifiedContentAnyOf")]',
    '[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>))]':
    '[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>), TypeInfoPropertyName = "ModifiedContentDictionary")]',
    '[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>), TypeInfoPropertyName = "OneOfNewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentTextNewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImageNewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideoNewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio2")]':
    '[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>), TypeInfoPropertyName = "ModifiedContentOneOf")]\n    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Nullable<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentText, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentImage, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo, global::ModerationAPI.NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentAudio>>), TypeInfoPropertyName = "NullableModifiedContentOneOf")]',
    '[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>))]':
    '[global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateRequestPolicieToxicity, global::ModerationAPI.NewModerateModerateRequestPoliciePersonalInformation, global::ModerationAPI.NewModerateModerateRequestPolicieToxicitySevere, global::ModerationAPI.NewModerateModerateRequestPolicieHate, global::ModerationAPI.NewModerateModerateRequestPolicieIllicit, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitDrugs, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitAlcohol, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitFirearms, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitTobacco, global::ModerationAPI.NewModerateModerateRequestPolicieIllicitGambling, global::ModerationAPI.NewModerateModerateRequestPolicieCannabis, global::ModerationAPI.NewModerateModerateRequestPolicieAdult, global::ModerationAPI.NewModerateModerateRequestPolicieCrypto, global::ModerationAPI.NewModerateModerateRequestPolicieSexual, global::ModerationAPI.NewModerateModerateRequestPolicieFlirtation, global::ModerationAPI.NewModerateModerateRequestPolicieProfanity, global::ModerationAPI.NewModerateModerateRequestPolicieViolence, global::ModerationAPI.NewModerateModerateRequestPolicieSelfHarm, global::ModerationAPI.NewModerateModerateRequestPolicieSpam, global::ModerationAPI.NewModerateModerateRequestPolicieSelfPromotion, global::ModerationAPI.NewModerateModerateRequestPoliciePolitical, global::ModerationAPI.NewModerateModerateRequestPolicieReligion, global::ModerationAPI.NewModerateModerateRequestPolicieCodeAbuse, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMasking, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMasking, global::ModerationAPI.NewModerateModerateRequestPolicieGuideline>>), TypeInfoPropertyName = "ModeratePoliciesList")]',
}

for old, new in replacements.items():
    if old not in text:
        raise SystemExit(f"Failed to apply JsonSerializerContext workaround for: {old[:80]}...")
    text = text.replace(old, new, 1)

path.write_text(text, encoding="utf-8")
PY
