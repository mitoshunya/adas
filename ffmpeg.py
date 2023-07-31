import ffmpeg 
 
# 入力 
stream = ffmpeg.input("test.mp4") 
aa = ffmpeg -i input.test.mp4
# 出力 
stream = ffmpeg.output(stream, "test.wav") 
# 実行
ffmpeg.run(stream)