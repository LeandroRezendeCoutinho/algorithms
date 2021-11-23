class Naive
  def self.search(text, pattern)
    text_length = text.length
    pattern_length = pattern.length

    (0..text_length - pattern_length).each do |i|
      (0..pattern_length - 1).each do |j|
        break if text[i + j] != pattern[j]

        puts "Pattern found at position#{i}" if j == pattern_length - 1
      end
    end
  end
end

text = 'AABAACAADAABAAABAA'
pattern = 'AABA'

Naive.search(text, pattern)
