from vosk import Model, KaldiRecognizer, SetLogLevel
import sys
import os
import wave
import soundfile
import json
import pprint

SetLogLevel(0)

if not os.path.exists("model"):
    print ("Please download the model from https://alphacephei.com/vosk/models and unpack as 'model' in the current folder.")
    exit (1)

# wav = "ai_servicesyuryo.wav"
# wf = wave.open(wav, "rb")
filepath = "test.wav"
tmp_filepath = 'tmp.wav'
sf = soundfile.SoundFile(filepath)
data = sf.read(-1)
print(sf.channels)
print(sf.format)
print(sf.subtype)
print(data)
if sf.channels != 1:
    data = [sum(d) / sf.channels for d in data ]
soundfile.write(tmp_filepath, data, sf.samplerate)
wf = wave.open(tmp_filepath, "rb")

if wf.getnchannels() != 1 or wf.getsampwidth() != 2 or wf.getcomptype() != "NONE":
    print ("Audio file must be WAV format mono PCM.")
    exit (1)

model = Model("model")
rec = KaldiRecognizer(model, wf.getframerate())
rec.SetWords(True)

while True:
    data = wf.readframes(16000)
    if len(data) == 0:
        break
    if rec.AcceptWaveform(data):
        result: json = json.loads(rec.Result())
        # text = result["result"].replace(" ", "")
        # print(result)
        pprint.pprint(result)
        

# print(rec.FinalResult())
result: json = json.loads(rec.FinalResult())
        # text = result["result"].replace(" ", "")
        # print(result)
pprint.pprint(result)